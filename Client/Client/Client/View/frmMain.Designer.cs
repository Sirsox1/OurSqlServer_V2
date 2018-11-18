namespace Client.View {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Database");
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.grpPanel = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.rdbHTTP = new System.Windows.Forms.RadioButton();
            this.rdbSQL = new System.Windows.Forms.RadioButton();
            this.grpMain.SuspendLayout();
            this.grpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnSend);
            this.grpMain.Controls.Add(this.txtReceived);
            this.grpMain.Controls.Add(this.txtQuery);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMain.Location = new System.Drawing.Point(209, 0);
            this.grpMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(0);
            this.grpMain.Size = new System.Drawing.Size(858, 554);
            this.grpMain.TabIndex = 10;
            this.grpMain.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(141, 130);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(232, 60);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtReceived.Location = new System.Drawing.Point(0, 219);
            this.txtReceived.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(858, 335);
            this.txtReceived.TabIndex = 2;
            // 
            // txtQuery
            // 
            this.txtQuery.AcceptsReturn = true;
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuery.Location = new System.Drawing.Point(0, 15);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(858, 102);
            this.txtQuery.TabIndex = 0;
            // 
            // grpPanel
            // 
            this.grpPanel.BackColor = System.Drawing.Color.White;
            this.grpPanel.Controls.Add(this.treeView1);
            this.grpPanel.Controls.Add(this.rdbHTTP);
            this.grpPanel.Controls.Add(this.rdbSQL);
            this.grpPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPanel.Location = new System.Drawing.Point(0, 0);
            this.grpPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPanel.Name = "grpPanel";
            this.grpPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPanel.Size = new System.Drawing.Size(209, 554);
            this.grpPanel.TabIndex = 9;
            this.grpPanel.TabStop = false;
            this.grpPanel.Text = "Panel";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView1.Location = new System.Drawing.Point(4, 130);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Database";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(201, 420);
            this.treeView1.TabIndex = 5;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick_1);
            // 
            // rdbHTTP
            // 
            this.rdbHTTP.AutoSize = true;
            this.rdbHTTP.Location = new System.Drawing.Point(16, 76);
            this.rdbHTTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbHTTP.Name = "rdbHTTP";
            this.rdbHTTP.Size = new System.Drawing.Size(66, 21);
            this.rdbHTTP.TabIndex = 4;
            this.rdbHTTP.TabStop = true;
            this.rdbHTTP.Text = "HTTP";
            this.rdbHTTP.UseVisualStyleBackColor = true;
            // 
            // rdbSQL
            // 
            this.rdbSQL.AutoSize = true;
            this.rdbSQL.Location = new System.Drawing.Point(16, 48);
            this.rdbSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSQL.Name = "rdbSQL";
            this.rdbSQL.Size = new System.Drawing.Size(57, 21);
            this.rdbSQL.TabIndex = 3;
            this.rdbSQL.TabStop = true;
            this.rdbSQL.Text = "SQL";
            this.rdbSQL.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.grpPanel.ResumeLayout(false);
            this.grpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.GroupBox grpPanel;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton rdbHTTP;
        private System.Windows.Forms.RadioButton rdbSQL;
    }
}