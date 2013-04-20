namespace ScriptExec
{
    partial class ScriptExec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptExec));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvScript = new System.Windows.Forms.ListView();
            this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Parameters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbScript = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbParameters = new System.Windows.Forms.TextBox();
            this.bExecScript = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bSaveGlobal = new System.Windows.Forms.Button();
            this.cbUNCPath = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lvScript, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbResults, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.47746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.52254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 601);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lvScript
            // 
            this.lvScript.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Filename,
            this.Parameters});
            this.lvScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvScript.FullRowSelect = true;
            this.lvScript.GridLines = true;
            this.lvScript.Location = new System.Drawing.Point(4, 4);
            this.lvScript.Margin = new System.Windows.Forms.Padding(4);
            this.lvScript.Name = "lvScript";
            this.lvScript.Size = new System.Drawing.Size(800, 255);
            this.lvScript.TabIndex = 0;
            this.lvScript.UseCompatibleStateImageBehavior = false;
            this.lvScript.View = System.Windows.Forms.View.Details;
            this.lvScript.SelectedIndexChanged += new System.EventHandler(this.lvScript_SelectedIndexChanged);
            this.lvScript.DoubleClick += new System.EventHandler(this.lvScript_DoubleClick);
            // 
            // Filename
            // 
            this.Filename.Text = "Filename";
            this.Filename.Width = 300;
            // 
            // Parameters
            // 
            this.Parameters.Text = "Parameters";
            this.Parameters.Width = 400;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 145);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbScript);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbParameters);
            this.tabPage1.Controls.Add(this.bExecScript);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scripts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbScript
            // 
            this.tbScript.Location = new System.Drawing.Point(54, 12);
            this.tbScript.Name = "tbScript";
            this.tbScript.Size = new System.Drawing.Size(323, 22);
            this.tbScript.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Script";
            // 
            // tbParameters
            // 
            this.tbParameters.Location = new System.Drawing.Point(383, 12);
            this.tbParameters.Name = "tbParameters";
            this.tbParameters.Size = new System.Drawing.Size(326, 22);
            this.tbParameters.TabIndex = 1;
            this.tbParameters.TextChanged += new System.EventHandler(this.tbParameters_TextChanged);
            // 
            // bExecScript
            // 
            this.bExecScript.Image = global::ScriptExec.Properties.Resources.control;
            this.bExecScript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bExecScript.Location = new System.Drawing.Point(6, 40);
            this.bExecScript.Name = "bExecScript";
            this.bExecScript.Size = new System.Drawing.Size(188, 54);
            this.bExecScript.TabIndex = 0;
            this.bExecScript.Text = "Execute selected script!";
            this.bExecScript.UseVisualStyleBackColor = true;
            this.bExecScript.Click += new System.EventHandler(this.bExecScript_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bSaveGlobal);
            this.tabPage2.Controls.Add(this.cbUNCPath);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbPassword);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbUsername);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Global";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bSaveGlobal
            // 
            this.bSaveGlobal.Image = global::ScriptExec.Properties.Resources.disk;
            this.bSaveGlobal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSaveGlobal.Location = new System.Drawing.Point(255, 37);
            this.bSaveGlobal.Name = "bSaveGlobal";
            this.bSaveGlobal.Size = new System.Drawing.Size(90, 56);
            this.bSaveGlobal.TabIndex = 7;
            this.bSaveGlobal.Text = "Save";
            this.bSaveGlobal.UseVisualStyleBackColor = true;
            this.bSaveGlobal.Click += new System.EventHandler(this.bSaveGlobal_Click);
            // 
            // cbUNCPath
            // 
            this.cbUNCPath.AutoSize = true;
            this.cbUNCPath.Image = global::ScriptExec.Properties.Resources.network;
            this.cbUNCPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbUNCPath.Location = new System.Drawing.Point(625, 8);
            this.cbUNCPath.Name = "cbUNCPath";
            this.cbUNCPath.Size = new System.Drawing.Size(72, 20);
            this.cbUNCPath.TabIndex = 6;
            this.cbUNCPath.Text = "UNC";
            this.cbUNCPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbUNCPath.UseVisualStyleBackColor = true;
            this.cbUNCPath.CheckedChanged += new System.EventHandler(this.cbUNCPath_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(127, 71);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 22);
            this.tbPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scripts path";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(127, 37);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(127, 5);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(492, 22);
            this.tbPath.TabIndex = 3;
            this.tbPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPath_KeyPress);
            // 
            // rtbResults
            // 
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResults.Location = new System.Drawing.Point(3, 438);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(802, 160);
            this.rtbResults.TabIndex = 2;
            this.rtbResults.Text = "";
            // 
            // ScriptExec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScriptExec";
            this.Text = "Script Exec";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColumnHeader Filename;
        private System.Windows.Forms.ColumnHeader Parameters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView lvScript;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bExecScript;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbUNCPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbParameters;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.TextBox tbScript;
        private System.Windows.Forms.Button bSaveGlobal;
    }
}

