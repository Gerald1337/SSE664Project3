namespace SSE664Project3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StoreContentsViewer = new System.Windows.Forms.DataGridView();
            this.WelcomeUserText = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernametext = new System.Windows.Forms.Label();
            this.passwordtext = new System.Windows.Forms.Label();
            this.purchasebutton = new System.Windows.Forms.Button();
            this.usingserverlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StoreContentsViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreContentsViewer
            // 
            this.StoreContentsViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreContentsViewer.Location = new System.Drawing.Point(12, 64);
            this.StoreContentsViewer.Name = "StoreContentsViewer";
            this.StoreContentsViewer.Size = new System.Drawing.Size(458, 374);
            this.StoreContentsViewer.TabIndex = 0;
            this.StoreContentsViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // WelcomeUserText
            // 
            this.WelcomeUserText.AutoSize = true;
            this.WelcomeUserText.Location = new System.Drawing.Point(524, 16);
            this.WelcomeUserText.Name = "WelcomeUserText";
            this.WelcomeUserText.Size = new System.Drawing.Size(86, 13);
            this.WelcomeUserText.TabIndex = 1;
            this.WelcomeUserText.Text = "Welcome, Guest";
            this.WelcomeUserText.Click += new System.EventHandler(this.WelcomeUserText_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(525, 64);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(525, 124);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // usernametext
            // 
            this.usernametext.AutoSize = true;
            this.usernametext.Location = new System.Drawing.Point(524, 48);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(55, 13);
            this.usernametext.TabIndex = 4;
            this.usernametext.Text = "Username";
            // 
            // passwordtext
            // 
            this.passwordtext.AutoSize = true;
            this.passwordtext.Location = new System.Drawing.Point(522, 108);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(53, 13);
            this.passwordtext.TabIndex = 5;
            this.passwordtext.Text = "Password";
            // 
            // purchasebutton
            // 
            this.purchasebutton.Enabled = false;
            this.purchasebutton.Location = new System.Drawing.Point(497, 403);
            this.purchasebutton.Name = "purchasebutton";
            this.purchasebutton.Size = new System.Drawing.Size(75, 23);
            this.purchasebutton.TabIndex = 6;
            this.purchasebutton.Text = "Purchase";
            this.purchasebutton.UseVisualStyleBackColor = true;
            // 
            // usingserverlabel
            // 
            this.usingserverlabel.AutoSize = true;
            this.usingserverlabel.Location = new System.Drawing.Point(494, 429);
            this.usingserverlabel.Name = "usingserverlabel";
            this.usingserverlabel.Size = new System.Drawing.Size(37, 13);
            this.usingserverlabel.TabIndex = 7;
            this.usingserverlabel.Text = "Using:";
            this.usingserverlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(59, 41);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(222, 20);
            this.searchbox.TabIndex = 10;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(299, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usingserverlabel);
            this.Controls.Add(this.purchasebutton);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.WelcomeUserText);
            this.Controls.Add(this.StoreContentsViewer);
            this.Name = "Form1";
            this.Text = "Amazon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StoreContentsViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StoreContentsViewer;
        private System.Windows.Forms.Label WelcomeUserText;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label usernametext;
        private System.Windows.Forms.Label passwordtext;
        private System.Windows.Forms.Button purchasebutton;
        private System.Windows.Forms.Label usingserverlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button searchButton;
    }
}

