namespace LeftRightRandomHalf {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.listRecord = new System.Windows.Forms.ListView();
            this.column0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPos0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPos1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPos2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPos3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPos4 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRecord
            // 
            this.listRecord.AllowDrop = true;
            this.listRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column0,
            this.column1});
            this.listRecord.FullRowSelect = true;
            this.listRecord.GridLines = true;
            this.listRecord.Location = new System.Drawing.Point(12, 12);
            this.listRecord.Name = "listRecord";
            this.listRecord.Size = new System.Drawing.Size(209, 286);
            this.listRecord.TabIndex = 0;
            this.listRecord.UseCompatibleStateImageBehavior = false;
            this.listRecord.View = System.Windows.Forms.View.Details;
            this.listRecord.VirtualMode = true;
            this.listRecord.CacheVirtualItems += new System.Windows.Forms.CacheVirtualItemsEventHandler(this.listRecord_CacheVirtualItems);
            this.listRecord.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listRecord_RetrieveVirtualItem);
            this.listRecord.DragDrop += new System.Windows.Forms.DragEventHandler(this.listRecord_DragDrop);
            this.listRecord.DragEnter += new System.Windows.Forms.DragEventHandler(this.listRecord_DragEnter);
            // 
            // column0
            // 
            this.column0.Text = "期号";
            this.column0.Width = 100;
            // 
            // column1
            // 
            this.column1.Text = "号码";
            this.column1.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "万";
            // 
            // txtBoxPos0
            // 
            this.txtBoxPos0.Location = new System.Drawing.Point(282, 87);
            this.txtBoxPos0.Name = "txtBoxPos0";
            this.txtBoxPos0.ReadOnly = true;
            this.txtBoxPos0.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos0.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "千";
            // 
            // txtBoxPos1
            // 
            this.txtBoxPos1.Location = new System.Drawing.Point(282, 120);
            this.txtBoxPos1.Name = "txtBoxPos1";
            this.txtBoxPos1.ReadOnly = true;
            this.txtBoxPos1.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "百";
            // 
            // txtBoxPos2
            // 
            this.txtBoxPos2.Location = new System.Drawing.Point(282, 153);
            this.txtBoxPos2.Name = "txtBoxPos2";
            this.txtBoxPos2.ReadOnly = true;
            this.txtBoxPos2.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "十";
            // 
            // txtBoxPos3
            // 
            this.txtBoxPos3.Location = new System.Drawing.Point(282, 186);
            this.txtBoxPos3.Name = "txtBoxPos3";
            this.txtBoxPos3.ReadOnly = true;
            this.txtBoxPos3.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "个";
            // 
            // txtBoxPos4
            // 
            this.txtBoxPos4.Location = new System.Drawing.Point(282, 219);
            this.txtBoxPos4.Name = "txtBoxPos4";
            this.txtBoxPos4.ReadOnly = true;
            this.txtBoxPos4.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos4.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(296, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "开  始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 309);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBoxPos4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxPos3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPos2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPos1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPos0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "上期号码左右各随机取一半";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPos0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPos1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPos2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPos3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPos4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ColumnHeader column0;
        private System.Windows.Forms.ColumnHeader column1;
    }
}

