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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Database");
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.prg1 = new System.Windows.Forms.ProgressBar();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.grpPanel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.rdbSQL = new System.Windows.Forms.RadioButton();
            this.grpMain.SuspendLayout();
            this.grpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.prg1);
            this.grpMain.Controls.Add(this.btnSend);
            this.grpMain.Controls.Add(this.txtReceived);
            this.grpMain.Controls.Add(this.txtQuery);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpMain.Location = new System.Drawing.Point(157, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Padding = new System.Windows.Forms.Padding(0);
            this.grpMain.Size = new System.Drawing.Size(643, 450);
            this.grpMain.TabIndex = 10;
            this.grpMain.TabStop = false;
            // 
            // prg1
            // 
            this.prg1.Location = new System.Drawing.Point(450, 115);
            this.prg1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prg1.Name = "prg1";
            this.prg1.Size = new System.Drawing.Size(134, 25);
            this.prg1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prg1.TabIndex = 11;
            this.prg1.Click += new System.EventHandler(this.prg1_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(244, 115);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(174, 49);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceived.Location = new System.Drawing.Point(0, 183);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(643, 267);
            this.txtReceived.TabIndex = 2;
            // 
            // txtQuery
            // 
            this.txtQuery.AcceptsReturn = true;
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Location = new System.Drawing.Point(0, 13);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(643, 80);
            this.txtQuery.TabIndex = 0;
            // 
            // grpPanel
            // 
            this.grpPanel.BackColor = System.Drawing.Color.White;
            this.grpPanel.Controls.Add(this.label1);
            this.grpPanel.Controls.Add(this.btnStatus);
            this.grpPanel.Controls.Add(this.treeView1);
            this.grpPanel.Controls.Add(this.rdbSQL);
            this.grpPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPanel.Location = new System.Drawing.Point(0, 0);
            this.grpPanel.Name = "grpPanel";
            this.grpPanel.Size = new System.Drawing.Size(157, 450);
            this.grpPanel.TabIndex = 9;
            this.grpPanel.TabStop = false;
            this.grpPanel.Text = "Explore Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stato Server";
            // 
            // btnStatus
            // 
            this.btnStatus.Enabled = false;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(12, 97);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(140, 30);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(3, 151);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "Nodo0";
            treeNode3.Text = "Database";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(151, 296);
            this.treeView1.TabIndex = 5;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick_1);
            // 
            // rdbSQL
            // 
            this.rdbSQL.AutoSize = true;
            this.rdbSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSQL.Location = new System.Drawing.Point(12, 33);
            this.rdbSQL.Name = "rdbSQL";
            this.rdbSQL.Size = new System.Drawing.Size(61, 24);
            this.rdbSQL.TabIndex = 3;
            this.rdbSQL.TabStop = true;
            this.rdbSQL.Text = "SQL";
            this.rdbSQL.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpPanel);
            this.Name = "frmMain";
            this.Text = "CLIENT";
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
        private System.Windows.Forms.RadioButton rdbSQL;
        private System.Windows.Forms.ProgressBar prg1;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label1;
    }
}