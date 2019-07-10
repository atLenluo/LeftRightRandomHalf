using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LotteryLib;

namespace LeftRightRandomHalf {
    public partial class MainForm : Form
    {
        struct GenCode
        {
            public int _curTimes;
            public List<string> _codeList;
        }

        private string _filePath;
        private List<TextBox> _txtBoxList = new List<TextBox> ();
        private List<GenCode> _genCodes = new List<GenCode>();
        private List<ListViewItem> _itemCacheList;
        private int _firstItem;
        private CodeStrategy _strategy = new CodeStrategy();
        private SortedList<string, CodeData> _codeRecords = new SortedList<string, CodeData>(new StringCompare());


        public MainForm() {
            InitializeComponent();
            _txtBoxList.AddRange(new TextBox[]
            {
                txtBoxPos0,
                txtBoxPos1,
                txtBoxPos2,
                txtBoxPos3,
                txtBoxPos4,
            });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_filePath == null) return;

            btnStart.Enabled = false;

            for (var i = 0; i < _txtBoxList.Count; i++)
            {
                GenCode genCode;
                genCode._curTimes = 0;
                genCode._codeList = _strategy.LeftMidRightRandomHalf(_codeRecords.Values, i);
                _genCodes.Add(genCode);
                _txtBoxList[i].Text = string.Join(" ", genCode._codeList);
            }
        }

        private void listRecord_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (_itemCacheList != null && e.ItemIndex >= _firstItem && e.ItemIndex < _firstItem + _itemCacheList.Count)
            {
                e.Item = _itemCacheList[e.ItemIndex - _firstItem];
            } else
            {
                var item = new ListViewItem();
                e.Item = item;
            }
            var data = _codeRecords.Values[e.ItemIndex];
            e.Item.SubItems.Clear();
            e.Item.Text = data.issue;
            e.Item.SubItems.Add(string.Join(",", data.codes));
        }

        private void listRecord_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
        }

        private void listRecord_DragDrop(object sender, DragEventArgs e)
        {
            if (_filePath != null)
                return;

            var filePaths = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (filePaths == null || filePaths.Length <= 0)
                return;

            var parser = new CodeParser();
            var data = parser.Parse(filePaths[0]);
            if (data == null || data.Count <= 0)  
                return;

            _filePath = filePaths[0];
            _codeRecords.Clear();
            foreach (var item in data)
            {
                _codeRecords.Add(item.issue, item);
            }

            listRecord.VirtualListSize = _codeRecords.Count;

            var dirName = Path.GetDirectoryName(_filePath);
            var fileName = Path.GetFileName(_filePath);

            if (dirName != null && fileName != null)
            {
                var fsw = new FileSystemWatcher(dirName, fileName) {
                    NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite
                };
                fsw.Changed += OnRecordFileChanged;
                fsw.EnableRaisingEvents = true;
            }
        }

        private void OnRecordFileChanged(object sender, FileSystemEventArgs e)
        {
            var parser = new CodeParser();
            var list = parser.Parse(_filePath, 1);
            if (list == null || list.Count <= 0 || _codeRecords.ContainsKey(list[0].issue)) return;

            _codeRecords.Add(list[0].issue, list[0]);
            listRecord.Invoke(new Action(delegate()
            {
                listRecord.VirtualListSize = _codeRecords.Count;
            }));

            for (var i = 0; i < _genCodes.Count; i++)
            {
                var genCode = _genCodes[i];

                genCode._curTimes = 0;
                genCode._codeList = _strategy.LeftMidRightRandomHalf(_codeRecords.Values, i);

                _genCodes[i] = genCode;
                _txtBoxList[i].Text = string.Join(" ", _genCodes[i]._codeList);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listRecord_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e) {
            if (_itemCacheList != null && e.StartIndex >= _firstItem && e.EndIndex <= _firstItem + _itemCacheList.Count)
            {
                return;
            }

            _firstItem = e.StartIndex;
            int length = e.EndIndex - e.StartIndex + 1;
            _itemCacheList = new List<ListViewItem>();
            for (int i = 0; i < length; i++)
            {
                var item = new ListViewItem();
                var data = _codeRecords.Values[i + e.StartIndex];
                item.Text = data.issue;
                item.SubItems.Add(string.Join(",", data.codes));
                _itemCacheList.Add(item);
            }
        }
    }
}
