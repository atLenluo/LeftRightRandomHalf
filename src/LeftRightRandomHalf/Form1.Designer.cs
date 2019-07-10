namespace LenHotWenHalfRandom {
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
            this.radioBtnZhuitou = new System.Windows.Forms.RadioButton();
            this.radioBtnQiqihuan = new System.Windows.Forms.RadioButton();
            this.txtBoxZhuitou = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listRecord
            // 
            this.listRecord.AllowDrop = true;
            this.listRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column0,
            this.column1});
            this.listRecord.Location = new System.Drawing.Point(12, 12);
            this.listRecord.Name = "listRecord";
            this.listRecord.Size = new System.Drawing.Size(209, 286);
            this.listRecord.TabIndex = 0;
            this.listRecord.UseCompatibleStateImageBehavior = false;
            this.listRecord.View = System.Windows.Forms.View.Details;
            this.listRecord.VirtualMode = true;
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
            this.label1.Location = new System.Drawing.Point(235, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // txtBoxPos0
            // 
            this.txtBoxPos0.Location = new System.Drawing.Point(282, 143);
            this.txtBoxPos0.Name = "txtBoxPos0";
            this.txtBoxPos0.ReadOnly = true;
            this.txtBoxPos0.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos0.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // txtBoxPos1
            // 
            this.txtBoxPos1.Location = new System.Drawing.Point(282, 176);
            this.txtBoxPos1.Name = "txtBoxPos1";
            this.txtBoxPos1.ReadOnly = true;
            this.txtBoxPos1.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // txtBoxPos2
            // 
            this.txtBoxPos2.Location = new System.Drawing.Point(282, 209);
            this.txtBoxPos2.Name = "txtBoxPos2";
            this.txtBoxPos2.ReadOnly = true;
            this.txtBoxPos2.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "label1";
            // 
            // txtBoxPos3
            // 
            this.txtBoxPos3.Location = new System.Drawing.Point(282, 242);
            this.txtBoxPos3.Name = "txtBoxPos3";
            this.txtBoxPos3.ReadOnly = true;
            this.txtBoxPos3.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "label1";
            // 
            // txtBoxPos4
            // 
            this.txtBoxPos4.Location = new System.Drawing.Point(282, 275);
            this.txtBoxPos4.Name = "txtBoxPos4";
            this.txtBoxPos4.ReadOnly = true;
            this.txtBoxPos4.Size = new System.Drawing.Size(141, 21);
            this.txtBoxPos4.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(296, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // radioBtnZhuitou
            // 
            this.radioBtnZhuitou.AutoSize = true;
            this.radioBtnZhuitou.Checked = true;
            this.radioBtnZhuitou.Location = new System.Drawing.Point(237, 57);
            this.radioBtnZhuitou.Name = "radioBtnZhuitou";
            this.radioBtnZhuitou.Size = new System.Drawing.Size(95, 16);
            this.radioBtnZhuitou.TabIndex = 4;
            this.radioBtnZhuitou.TabStop = true;
            this.radioBtnZhuitou.Text = "radioButton1";
            this.radioBtnZhuitou.UseVisualStyleBackColor = true;
            // 
            // radioBtnQiqihuan
            // 
            this.radioBtnQiqihuan.AutoSize = true;
            this.radioBtnQiqihuan.Location = new System.Drawing.Point(237, 94);
            this.radioBtnQiqihuan.Name = "radioBtnQiqihuan";
            this.radioBtnQiqihuan.Size = new System.Drawing.Size(95, 16);
            this.radioBtnQiqihuan.TabIndex = 4;
            this.radioBtnQiqihuan.Text = "radioButton1";
            this.radioBtnQiqihuan.UseVisualStyleBackColor = true;
            // 
            // txtBoxZhuitou
            // 
            this.txtBoxZhuitou.Location = new System.Drawing.Point(338, 56);
            this.txtBoxZhuitou.Name = "txtBoxZhuitou";
            this.txtBoxZhuitou.Size = new System.Drawing.Size(85, 21);
            this.txtBoxZhuitou.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 309);
            this.Controls.Add(this.txtBoxZhuitou);
            this.Controls.Add(this.radioBtnQiqihuan);
            this.Controls.Add(this.radioBtnZhuitou);
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
            this.Name = "MainForm";
            this.Text = "MainForm";
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
        private System.Windows.Forms.RadioButton radioBtnZhuitou;
        private System.Windows.Forms.RadioButton radioBtnQiqihuan;
        private System.Windows.Forms.TextBox txtBoxZhuitou;
        private System.Windows.Forms.ColumnHeader column0;
        private System.Windows.Forms.ColumnHeader column1;
    }
}

