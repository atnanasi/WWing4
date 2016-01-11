namespace Wwing4
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.ComboBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.newTabButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.closeMenuButton = new System.Windows.Forms.Button();
            this.configButton = new System.Windows.Forms.Button();
            this.newWindowButton = new System.Windows.Forms.Button();
            this.wwingTitle = new System.Windows.Forms.Label();
            this.menuTabButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.versionButton = new System.Windows.Forms.Button();
            this.tabControlEx1 = new Wwing4.TabControlEx();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.backButton.Location = new System.Drawing.Point(84, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(28, 28);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nextButton.Location = new System.Drawing.Point(118, 12);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(28, 28);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "→";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reloadButton.Location = new System.Drawing.Point(152, 12);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(28, 28);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "⟳";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Location = new System.Drawing.Point(254, 12);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(295, 28);
            this.addressBox.TabIndex = 3;
            this.addressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBox_KeyDown);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stopButton.Location = new System.Drawing.Point(186, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(28, 28);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "x";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuButton.Location = new System.Drawing.Point(12, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(66, 28);
            this.menuButton.TabIndex = 5;
            this.menuButton.Text = "Wwing";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(555, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(34, 28);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // newTabButton
            // 
            this.newTabButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTabButton.Location = new System.Drawing.Point(220, 12);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(28, 28);
            this.newTabButton.TabIndex = 8;
            this.newTabButton.Text = "+";
            this.newTabButton.UseVisualStyleBackColor = true;
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.versionButton);
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.closeMenuButton);
            this.menuPanel.Controls.Add(this.configButton);
            this.menuPanel.Controls.Add(this.newWindowButton);
            this.menuPanel.Controls.Add(this.wwingTitle);
            this.menuPanel.Controls.Add(this.menuTabButton);
            this.menuPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.menuPanel.Location = new System.Drawing.Point(7, 46);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(207, 335);
            this.menuPanel.TabIndex = 9;
            this.menuPanel.Visible = false;
            // 
            // closeMenuButton
            // 
            this.closeMenuButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMenuButton.Location = new System.Drawing.Point(145, 3);
            this.closeMenuButton.Name = "closeMenuButton";
            this.closeMenuButton.Size = new System.Drawing.Size(59, 23);
            this.closeMenuButton.TabIndex = 7;
            this.closeMenuButton.Text = "閉じる";
            this.closeMenuButton.UseVisualStyleBackColor = true;
            this.closeMenuButton.Click += new System.EventHandler(this.closeMenuButton_Click);
            // 
            // configButton
            // 
            this.configButton.Location = new System.Drawing.Point(3, 223);
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(201, 23);
            this.configButton.TabIndex = 6;
            this.configButton.Text = "Wwingの設定";
            this.configButton.UseVisualStyleBackColor = true;
            // 
            // newWindowButton
            // 
            this.newWindowButton.Location = new System.Drawing.Point(104, 43);
            this.newWindowButton.Name = "newWindowButton";
            this.newWindowButton.Size = new System.Drawing.Size(100, 23);
            this.newWindowButton.TabIndex = 5;
            this.newWindowButton.Text = "新規ウィンドウ";
            this.newWindowButton.UseVisualStyleBackColor = true;
            // 
            // wwingTitle
            // 
            this.wwingTitle.AutoSize = true;
            this.wwingTitle.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wwingTitle.Location = new System.Drawing.Point(3, 4);
            this.wwingTitle.Name = "wwingTitle";
            this.wwingTitle.Size = new System.Drawing.Size(116, 36);
            this.wwingTitle.TabIndex = 4;
            this.wwingTitle.Text = "Wwing4";
            // 
            // menuTabButton
            // 
            this.menuTabButton.Location = new System.Drawing.Point(3, 43);
            this.menuTabButton.Name = "menuTabButton";
            this.menuTabButton.Size = new System.Drawing.Size(100, 23);
            this.menuTabButton.TabIndex = 0;
            this.menuTabButton.Text = "新規タブ";
            this.menuTabButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(201, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Wwingを終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(3, 252);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(201, 23);
            this.helpButton.TabIndex = 9;
            this.helpButton.Text = "WWingのヘルプ";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // versionButton
            // 
            this.versionButton.Location = new System.Drawing.Point(3, 280);
            this.versionButton.Name = "versionButton";
            this.versionButton.Size = new System.Drawing.Size(201, 23);
            this.versionButton.TabIndex = 10;
            this.versionButton.Text = "Wwingのバージョン";
            this.versionButton.UseVisualStyleBackColor = true;
            this.versionButton.Click += new System.EventHandler(this.versionButton_Click);
            // 
            // tabControlEx1
            // 
            this.tabControlEx1.AllowDrop = true;
            this.tabControlEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEx1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlEx1.Location = new System.Drawing.Point(0, 46);
            this.tabControlEx1.Name = "tabControlEx1";
            this.tabControlEx1.SelectedIndex = 0;
            this.tabControlEx1.Size = new System.Drawing.Size(601, 342);
            this.tabControlEx1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlEx1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 388);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.newTabButton);
            this.Controls.Add(this.tabControlEx1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Name = "Form1";
            this.Text = "Wwing4";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button reloadButton;
        public System.Windows.Forms.ComboBox addressBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button newTabButton;
        private TabControlEx tabControlEx1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button menuTabButton;
        private System.Windows.Forms.Label wwingTitle;
        private System.Windows.Forms.Button newWindowButton;
        private System.Windows.Forms.Button configButton;
        private System.Windows.Forms.Button closeMenuButton;
        private System.Windows.Forms.Button versionButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
    }
}

