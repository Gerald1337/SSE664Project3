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
            this.createUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StoreContentsViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreContentsViewer
            // 
            this.StoreContentsViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreContentsViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StoreContentsViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StoreContentsViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreContentsViewer.Location = new System.Drawing.Point(22, 118);
            this.StoreContentsViewer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StoreContentsViewer.Name = "StoreContentsViewer";
            this.StoreContentsViewer.RowHeadersWidth = 72;
            this.StoreContentsViewer.Size = new System.Drawing.Size(840, 690);
            this.StoreContentsViewer.TabIndex = 0;
            this.StoreContentsViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // WelcomeUserText
            // 
            this.WelcomeUserText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeUserText.AutoSize = true;
            this.WelcomeUserText.Location = new System.Drawing.Point(961, 30);
            this.WelcomeUserText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WelcomeUserText.Name = "WelcomeUserText";
            this.WelcomeUserText.Size = new System.Drawing.Size(157, 25);
            this.WelcomeUserText.TabIndex = 1;
            this.WelcomeUserText.Text = "Welcome, Guest";
            this.WelcomeUserText.Click += new System.EventHandler(this.WelcomeUserText_Click);
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username.Location = new System.Drawing.Point(963, 118);
            this.username.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(180, 29);
            this.username.TabIndex = 2;
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Location = new System.Drawing.Point(963, 229);
            this.password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(180, 29);
            this.password.TabIndex = 3;
            // 
            // usernametext
            // 
            this.usernametext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernametext.AutoSize = true;
            this.usernametext.Location = new System.Drawing.Point(961, 89);
            this.usernametext.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(102, 25);
            this.usernametext.TabIndex = 4;
            this.usernametext.Text = "Username";
            // 
            // passwordtext
            // 
            this.passwordtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordtext.AutoSize = true;
            this.passwordtext.Location = new System.Drawing.Point(957, 199);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(98, 25);
            this.passwordtext.TabIndex = 5;
            this.passwordtext.Text = "Password";
            // 
            // purchasebutton
            // 
            this.purchasebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasebutton.Enabled = false;
            this.purchasebutton.Location = new System.Drawing.Point(911, 744);
            this.purchasebutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.purchasebutton.Name = "purchasebutton";
            this.purchasebutton.Size = new System.Drawing.Size(138, 42);
            this.purchasebutton.TabIndex = 6;
            this.purchasebutton.Text = "Purchase";
            this.purchasebutton.UseVisualStyleBackColor = true;
            // 
            // usingserverlabel
            // 
            this.usingserverlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usingserverlabel.AutoSize = true;
            this.usingserverlabel.Location = new System.Drawing.Point(906, 792);
            this.usingserverlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usingserverlabel.Name = "usingserverlabel";
            this.usingserverlabel.Size = new System.Drawing.Size(68, 25);
            this.usingserverlabel.TabIndex = 7;
            this.usingserverlabel.Text = "Using:";
            this.usingserverlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(963, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(108, 76);
            this.searchbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(404, 29);
            this.searchbox.TabIndex = 10;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(548, 70);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 42);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // createUserButton
            // 
            this.createUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createUserButton.Location = new System.Drawing.Point(963, 377);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(138, 42);
            this.createUserButton.TabIndex = 12;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 831);
            this.Controls.Add(this.createUserButton);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
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
        private System.Windows.Forms.Button createUserButton;
    }
}

