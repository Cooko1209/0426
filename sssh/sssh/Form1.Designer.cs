namespace sssh
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbb_option = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_execute = new System.Windows.Forms.Button();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.cbb2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbb_option
            // 
            this.cbb_option.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbb_option.FormattingEnabled = true;
            this.cbb_option.Items.AddRange(new object[] {
            "1.首次上傳Github",
            "2.本機上傳已連結Github資料夾",
            "3.未知的功能",
            "4.可編寫Github提交(commit)並執行同步(push)",
            "5.下載git資料(clone)",
            "6.返回上層選單",
            "7.退出程序"});
            this.cbb_option.Location = new System.Drawing.Point(155, 55);
            this.cbb_option.Name = "cbb_option";
            this.cbb_option.Size = new System.Drawing.Size(282, 24);
            this.cbb_option.TabIndex = 0;
            this.cbb_option.Tag = "";
            this.cbb_option.Text = "1.首次上傳Github";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(67, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Github選單";
            // 
            // btn_execute
            // 
            this.btn_execute.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_execute.Location = new System.Drawing.Point(70, 99);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(124, 45);
            this.btn_execute.TabIndex = 2;
            this.btn_execute.Text = "開始執行";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // cbb1
            // 
            this.cbb1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "1.aaaaa",
            "2.bbbb",
            "3.ccccc"});
            this.cbb1.Location = new System.Drawing.Point(80, 183);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(121, 27);
            this.cbb1.TabIndex = 3;
            this.cbb1.Text = "1.aaaaa";
            this.cbb1.SelectedIndexChanged += new System.EventHandler(this.cbb1_SelectedIndexChanged);
            // 
            // cbb2
            // 
            this.cbb2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbb2.FormattingEnabled = true;
            this.cbb2.Location = new System.Drawing.Point(226, 183);
            this.cbb2.Name = "cbb2";
            this.cbb2.Size = new System.Drawing.Size(134, 27);
            this.cbb2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb2);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_option);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_option;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.ComboBox cbb2;
    }
}

