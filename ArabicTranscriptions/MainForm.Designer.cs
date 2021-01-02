
namespace ArabicTranscriptions
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.buttonTranscribe = new System.Windows.Forms.Button();
			this.groupBoxResult = new System.Windows.Forms.GroupBox();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.groupBoxArabic = new System.Windows.Forms.GroupBox();
			this.textBoxArabic = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.groupBoxResult.SuspendLayout();
			this.groupBoxArabic.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.ShowItemToolTips = true;
			this.menuStrip.Size = new System.Drawing.Size(365, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "Menu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.buttonTranscribe);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxResult);
			this.toolStripContainer.ContentPanel.Controls.Add(this.groupBoxArabic);
			this.toolStripContainer.ContentPanel.Controls.Add(this.statusStrip);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(365, 360);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(365, 384);
			this.toolStripContainer.TabIndex = 1;
			this.toolStripContainer.Text = "toolStripContainerMain";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
			// 
			// buttonTranscribe
			// 
			this.buttonTranscribe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTranscribe.Location = new System.Drawing.Point(15, 159);
			this.buttonTranscribe.Name = "buttonTranscribe";
			this.buttonTranscribe.Size = new System.Drawing.Size(335, 23);
			this.buttonTranscribe.TabIndex = 1;
			this.buttonTranscribe.Text = "Transcript";
			this.toolTip.SetToolTip(this.buttonTranscribe, "Transcribe");
			this.buttonTranscribe.UseVisualStyleBackColor = true;
			// 
			// groupBoxResult
			// 
			this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxResult.Controls.Add(this.textBoxResult);
			this.groupBoxResult.Location = new System.Drawing.Point(12, 188);
			this.groupBoxResult.Name = "groupBoxResult";
			this.groupBoxResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBoxResult.Size = new System.Drawing.Size(341, 150);
			this.groupBoxResult.TabIndex = 2;
			this.groupBoxResult.TabStop = false;
			this.groupBoxResult.Text = "Result";
			// 
			// textBoxResult
			// 
			this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxResult.Location = new System.Drawing.Point(3, 16);
			this.textBoxResult.MaxLength = 9999999;
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxResult.Size = new System.Drawing.Size(335, 131);
			this.textBoxResult.TabIndex = 0;
			// 
			// groupBoxArabic
			// 
			this.groupBoxArabic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxArabic.Controls.Add(this.textBoxArabic);
			this.groupBoxArabic.Location = new System.Drawing.Point(12, 3);
			this.groupBoxArabic.Name = "groupBoxArabic";
			this.groupBoxArabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBoxArabic.Size = new System.Drawing.Size(341, 150);
			this.groupBoxArabic.TabIndex = 0;
			this.groupBoxArabic.TabStop = false;
			this.groupBoxArabic.Text = "Arabic / عربى";
			// 
			// textBoxArabic
			// 
			this.textBoxArabic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxArabic.Location = new System.Drawing.Point(3, 16);
			this.textBoxArabic.MaxLength = 9999999;
			this.textBoxArabic.Multiline = true;
			this.textBoxArabic.Name = "textBoxArabic";
			this.textBoxArabic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxArabic.Size = new System.Drawing.Size(335, 131);
			this.textBoxArabic.TabIndex = 0;
			// 
			// statusStrip
			// 
			this.statusStrip.Location = new System.Drawing.Point(0, 338);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(365, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 3;
			this.statusStrip.TabStop = true;
			this.statusStrip.Text = "statusStrip";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 384);
			this.Controls.Add(this.toolStripContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Arabic Transcriptions";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ContentPanel.PerformLayout();
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.groupBoxResult.ResumeLayout(false);
			this.groupBoxResult.PerformLayout();
			this.groupBoxArabic.ResumeLayout(false);
			this.groupBoxArabic.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.GroupBox groupBoxArabic;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.GroupBox groupBoxResult;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.TextBox textBoxArabic;
		private System.Windows.Forms.Button buttonTranscribe;
	}
}

