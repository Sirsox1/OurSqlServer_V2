﻿namespace Server {
    partial class frmServer {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtQueryElaborata = new System.Windows.Forms.TextBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtErrorReport = new System.Windows.Forms.TextBox();
            this.srlPortServer = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(149, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(477, 61);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // txtQueryElaborata
            // 
            this.txtQueryElaborata.Enabled = false;
            this.txtQueryElaborata.Location = new System.Drawing.Point(149, 70);
            this.txtQueryElaborata.Multiline = true;
            this.txtQueryElaborata.Name = "txtQueryElaborata";
            this.txtQueryElaborata.Size = new System.Drawing.Size(477, 307);
            this.txtQueryElaborata.TabIndex = 1;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnStopServer
            // 
            this.btnStopServer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStopServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopServer.Location = new System.Drawing.Point(12, 37);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(123, 28);
            this.btnStopServer.TabIndex = 7;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = false;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.Location = new System.Drawing.Point(12, 3);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(123, 28);
            this.btnStartServer.TabIndex = 8;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtErrorReport
            // 
            this.txtErrorReport.Enabled = false;
            this.txtErrorReport.Location = new System.Drawing.Point(149, 383);
            this.txtErrorReport.Multiline = true;
            this.txtErrorReport.Name = "txtErrorReport";
            this.txtErrorReport.Size = new System.Drawing.Size(477, 55);
            this.txtErrorReport.TabIndex = 9;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.txtErrorReport);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.txtQueryElaborata);
            this.Controls.Add(this.txtQuery);
            this.Name = "frmServer";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtQueryElaborata;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtErrorReport;
        private System.IO.Ports.SerialPort srlPortServer;
    }
}
