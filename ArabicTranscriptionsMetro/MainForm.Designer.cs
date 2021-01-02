
namespace ArabicTranscriptionsMetro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.metroToolTip = new MetroFramework.Components.MetroToolTip();
			this.metroTabPageOptions = new MetroFramework.Controls.MetroTabPage();
			this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPageTranscription = new MetroFramework.Controls.MetroTabPage();
			this.metroLabelResult = new MetroFramework.Controls.MetroLabel();
			this.metroTextBoxResult = new MetroFramework.Controls.MetroTextBox();
			this.metroLabelArabic = new MetroFramework.Controls.MetroLabel();
			this.metroTextBoxArabic = new MetroFramework.Controls.MetroTextBox();
			this.metroButtonTranscribe = new MetroFramework.Controls.MetroButton();
			this.metroTabPageAbout = new MetroFramework.Controls.MetroTabPage();
			this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
			this.metroLabelProductName = new MetroFramework.Controls.MetroLabel();
			this.metroLabelVersion = new MetroFramework.Controls.MetroLabel();
			this.metroLabelCopyright = new MetroFramework.Controls.MetroLabel();
			this.metroLabelCompany = new MetroFramework.Controls.MetroLabel();
			this.metroLinkWebsite = new MetroFramework.Controls.MetroLink();
			this.metroTextBoxDescription = new MetroFramework.Controls.MetroTextBox();
			this.metroCheckBoxApplyNumbers = new MetroFramework.Controls.MetroCheckBox();
			this.metroCheckBoxRemoveMultipleSpaces = new MetroFramework.Controls.MetroCheckBox();
			this.metroCheckBoxShowStatisticAfterFinish = new MetroFramework.Controls.MetroCheckBox();
			this.metroTabPageOptions.SuspendLayout();
			this.metroTabControl.SuspendLayout();
			this.metroTabPageTranscription.SuspendLayout();
			this.metroTabPageAbout.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroToolTip
			// 
			this.metroToolTip.Style = MetroFramework.MetroColorStyle.Red;
			this.metroToolTip.StyleManager = null;
			this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroTabPageOptions
			// 
			this.metroTabPageOptions.Controls.Add(this.metroCheckBoxShowStatisticAfterFinish);
			this.metroTabPageOptions.Controls.Add(this.metroCheckBoxRemoveMultipleSpaces);
			this.metroTabPageOptions.Controls.Add(this.metroCheckBoxApplyNumbers);
			this.metroTabPageOptions.HorizontalScrollbarBarColor = true;
			this.metroTabPageOptions.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPageOptions.HorizontalScrollbarSize = 10;
			this.metroTabPageOptions.Location = new System.Drawing.Point(4, 38);
			this.metroTabPageOptions.Name = "metroTabPageOptions";
			this.metroTabPageOptions.Size = new System.Drawing.Size(333, 301);
			this.metroTabPageOptions.TabIndex = 1;
			this.metroTabPageOptions.Text = "Options";
			this.metroTabPageOptions.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTabPageOptions.ToolTipText = "Options";
			this.metroTabPageOptions.VerticalScrollbarBarColor = true;
			this.metroTabPageOptions.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPageOptions.VerticalScrollbarSize = 10;
			// 
			// metroTabControl
			// 
			this.metroTabControl.Controls.Add(this.metroTabPageTranscription);
			this.metroTabControl.Controls.Add(this.metroTabPageOptions);
			this.metroTabControl.Controls.Add(this.metroTabPageAbout);
			this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
			this.metroTabControl.Location = new System.Drawing.Point(20, 60);
			this.metroTabControl.Name = "metroTabControl";
			this.metroTabControl.SelectedIndex = 1;
			this.metroTabControl.ShowToolTips = true;
			this.metroTabControl.Size = new System.Drawing.Size(341, 343);
			this.metroTabControl.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroTabControl.TabIndex = 0;
			this.metroTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTabControl.UseSelectable = true;
			// 
			// metroTabPageTranscription
			// 
			this.metroTabPageTranscription.Controls.Add(this.metroLabelResult);
			this.metroTabPageTranscription.Controls.Add(this.metroTextBoxResult);
			this.metroTabPageTranscription.Controls.Add(this.metroLabelArabic);
			this.metroTabPageTranscription.Controls.Add(this.metroTextBoxArabic);
			this.metroTabPageTranscription.Controls.Add(this.metroButtonTranscribe);
			this.metroTabPageTranscription.HorizontalScrollbarBarColor = true;
			this.metroTabPageTranscription.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPageTranscription.HorizontalScrollbarSize = 10;
			this.metroTabPageTranscription.Location = new System.Drawing.Point(4, 38);
			this.metroTabPageTranscription.Name = "metroTabPageTranscription";
			this.metroTabPageTranscription.Size = new System.Drawing.Size(333, 301);
			this.metroTabPageTranscription.Style = MetroFramework.MetroColorStyle.Red;
			this.metroTabPageTranscription.TabIndex = 0;
			this.metroTabPageTranscription.Text = "Transcription";
			this.metroTabPageTranscription.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTabPageTranscription.ToolTipText = "Transcription";
			this.metroTabPageTranscription.VerticalScrollbarBarColor = true;
			this.metroTabPageTranscription.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPageTranscription.VerticalScrollbarSize = 10;
			// 
			// metroLabelResult
			// 
			this.metroLabelResult.AutoSize = true;
			this.metroLabelResult.Location = new System.Drawing.Point(0, 162);
			this.metroLabelResult.Name = "metroLabelResult";
			this.metroLabelResult.Size = new System.Drawing.Size(43, 19);
			this.metroLabelResult.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLabelResult.TabIndex = 3;
			this.metroLabelResult.Text = "Result";
			this.metroLabelResult.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroTextBoxResult
			// 
			// 
			// 
			// 
			this.metroTextBoxResult.CustomButton.Image = null;
			this.metroTextBoxResult.CustomButton.Location = new System.Drawing.Point(224, 2);
			this.metroTextBoxResult.CustomButton.Name = "";
			this.metroTextBoxResult.CustomButton.Size = new System.Drawing.Size(103, 103);
			this.metroTextBoxResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBoxResult.CustomButton.TabIndex = 1;
			this.metroTextBoxResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBoxResult.CustomButton.UseSelectable = true;
			this.metroTextBoxResult.CustomButton.Visible = false;
			this.metroTextBoxResult.Lines = new string[0];
			this.metroTextBoxResult.Location = new System.Drawing.Point(0, 184);
			this.metroTextBoxResult.MaxLength = 9999999;
			this.metroTextBoxResult.Multiline = true;
			this.metroTextBoxResult.Name = "metroTextBoxResult";
			this.metroTextBoxResult.PasswordChar = '\0';
#pragma warning disable CS0618 // Typ oder Element ist veraltet
			this.metroTextBoxResult.PromptText = "result here";
#pragma warning restore CS0618 // Typ oder Element ist veraltet
			this.metroTextBoxResult.ReadOnly = true;
			this.metroTextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.metroTextBoxResult.SelectedText = "";
			this.metroTextBoxResult.SelectionLength = 0;
			this.metroTextBoxResult.SelectionStart = 0;
			this.metroTextBoxResult.ShortcutsEnabled = true;
			this.metroTextBoxResult.Size = new System.Drawing.Size(330, 108);
			this.metroTextBoxResult.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroTextBoxResult.TabIndex = 4;
			this.metroTextBoxResult.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroTextBoxResult, "Result");
			this.metroTextBoxResult.UseSelectable = true;
			this.metroTextBoxResult.WaterMark = "result here";
			this.metroTextBoxResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBoxResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabelArabic
			// 
			this.metroLabelArabic.AutoSize = true;
			this.metroLabelArabic.Location = new System.Drawing.Point(241, 0);
			this.metroLabelArabic.Name = "metroLabelArabic";
			this.metroLabelArabic.Size = new System.Drawing.Size(89, 19);
			this.metroLabelArabic.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLabelArabic.TabIndex = 0;
			this.metroLabelArabic.Text = "Arabic / عربى";
			this.metroLabelArabic.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroTextBoxArabic
			// 
			// 
			// 
			// 
			this.metroTextBoxArabic.CustomButton.Image = null;
			this.metroTextBoxArabic.CustomButton.Location = new System.Drawing.Point(224, 2);
			this.metroTextBoxArabic.CustomButton.Name = "";
			this.metroTextBoxArabic.CustomButton.Size = new System.Drawing.Size(103, 103);
			this.metroTextBoxArabic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBoxArabic.CustomButton.TabIndex = 1;
			this.metroTextBoxArabic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBoxArabic.CustomButton.UseSelectable = true;
			this.metroTextBoxArabic.CustomButton.Visible = false;
			this.metroTextBoxArabic.Lines = new string[0];
			this.metroTextBoxArabic.Location = new System.Drawing.Point(0, 22);
			this.metroTextBoxArabic.MaxLength = 9999999;
			this.metroTextBoxArabic.Multiline = true;
			this.metroTextBoxArabic.Name = "metroTextBoxArabic";
			this.metroTextBoxArabic.PasswordChar = '\0';
#pragma warning disable CS0618 // Typ oder Element ist veraltet
			this.metroTextBoxArabic.PromptText = "arabic text here";
#pragma warning restore CS0618 // Typ oder Element ist veraltet
			this.metroTextBoxArabic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.metroTextBoxArabic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.metroTextBoxArabic.SelectedText = "";
			this.metroTextBoxArabic.SelectionLength = 0;
			this.metroTextBoxArabic.SelectionStart = 0;
			this.metroTextBoxArabic.ShortcutsEnabled = true;
			this.metroTextBoxArabic.Size = new System.Drawing.Size(330, 108);
			this.metroTextBoxArabic.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroTextBoxArabic.TabIndex = 1;
			this.metroTextBoxArabic.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroTextBoxArabic, "Arabic");
			this.metroTextBoxArabic.UseSelectable = true;
			this.metroTextBoxArabic.WaterMark = "arabic text here";
			this.metroTextBoxArabic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBoxArabic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroButtonTranscribe
			// 
			this.metroButtonTranscribe.Highlight = true;
			this.metroButtonTranscribe.Location = new System.Drawing.Point(0, 136);
			this.metroButtonTranscribe.Name = "metroButtonTranscribe";
			this.metroButtonTranscribe.Size = new System.Drawing.Size(330, 23);
			this.metroButtonTranscribe.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroButtonTranscribe.TabIndex = 2;
			this.metroButtonTranscribe.Text = "Transcribe";
			this.metroButtonTranscribe.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroButtonTranscribe, "Transcribe");
			this.metroButtonTranscribe.UseSelectable = true;
			this.metroButtonTranscribe.Click += new System.EventHandler(this.MetroButtonTranscribe_Click);
			// 
			// metroTabPageAbout
			// 
			this.metroTabPageAbout.Controls.Add(this.metroTextBoxDescription);
			this.metroTabPageAbout.Controls.Add(this.metroLinkWebsite);
			this.metroTabPageAbout.Controls.Add(this.metroLabelCompany);
			this.metroTabPageAbout.Controls.Add(this.metroLabelCopyright);
			this.metroTabPageAbout.Controls.Add(this.metroLabelVersion);
			this.metroTabPageAbout.Controls.Add(this.metroLabelProductName);
			this.metroTabPageAbout.Controls.Add(this.metroUserControl1);
			this.metroTabPageAbout.HorizontalScrollbarBarColor = true;
			this.metroTabPageAbout.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPageAbout.HorizontalScrollbarSize = 10;
			this.metroTabPageAbout.Location = new System.Drawing.Point(4, 38);
			this.metroTabPageAbout.Name = "metroTabPageAbout";
			this.metroTabPageAbout.Size = new System.Drawing.Size(333, 301);
			this.metroTabPageAbout.TabIndex = 2;
			this.metroTabPageAbout.Text = "About";
			this.metroTabPageAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTabPageAbout.ToolTipText = "About";
			this.metroTabPageAbout.VerticalScrollbarBarColor = true;
			this.metroTabPageAbout.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPageAbout.VerticalScrollbarSize = 10;
			// 
			// metroUserControl1
			// 
			this.metroUserControl1.BackColor = System.Drawing.Color.Transparent;
			this.metroUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroUserControl1.BackgroundImage")));
			this.metroUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.metroUserControl1.Location = new System.Drawing.Point(-4, 3);
			this.metroUserControl1.Name = "metroUserControl1";
			this.metroUserControl1.Size = new System.Drawing.Size(150, 150);
			this.metroUserControl1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroUserControl1.TabIndex = 0;
			this.metroUserControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroUserControl1, "Logo");
			this.metroUserControl1.UseSelectable = true;
			// 
			// metroLabelProductName
			// 
			this.metroLabelProductName.AutoSize = true;
			this.metroLabelProductName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabelProductName.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
			this.metroLabelProductName.Location = new System.Drawing.Point(153, 17);
			this.metroLabelProductName.Name = "metroLabelProductName";
			this.metroLabelProductName.Size = new System.Drawing.Size(97, 19);
			this.metroLabelProductName.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLabelProductName.TabIndex = 1;
			this.metroLabelProductName.Text = "Product Name";
			this.metroLabelProductName.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroLabelProductName, "Product Name");
			// 
			// metroLabelVersion
			// 
			this.metroLabelVersion.AutoSize = true;
			this.metroLabelVersion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabelVersion.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
			this.metroLabelVersion.Location = new System.Drawing.Point(153, 36);
			this.metroLabelVersion.Name = "metroLabelVersion";
			this.metroLabelVersion.Size = new System.Drawing.Size(54, 19);
			this.metroLabelVersion.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLabelVersion.TabIndex = 2;
			this.metroLabelVersion.Text = "Version";
			this.metroLabelVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroLabelVersion, "Version");
			// 
			// metroLabelCopyright
			// 
			this.metroLabelCopyright.AutoSize = true;
			this.metroLabelCopyright.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabelCopyright.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
			this.metroLabelCopyright.Location = new System.Drawing.Point(153, 55);
			this.metroLabelCopyright.Name = "metroLabelCopyright";
			this.metroLabelCopyright.Size = new System.Drawing.Size(70, 19);
			this.metroLabelCopyright.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLabelCopyright.TabIndex = 3;
			this.metroLabelCopyright.Text = "Copyright";
			this.metroLabelCopyright.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroLabelCopyright, "Copyright");
			// 
			// metroLabelCompany
			// 
			this.metroLabelCompany.AutoSize = true;
			this.metroLabelCompany.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabelCompany.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
			this.metroLabelCompany.Location = new System.Drawing.Point(153, 74);
			this.metroLabelCompany.Name = "metroLabelCompany";
			this.metroLabelCompany.Size = new System.Drawing.Size(68, 19);
			this.metroLabelCompany.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLabelCompany.TabIndex = 4;
			this.metroLabelCompany.Text = "Company";
			this.metroLabelCompany.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroLabelCompany, "Company");
			// 
			// metroLinkWebsite
			// 
			this.metroLinkWebsite.Image = ((System.Drawing.Image)(resources.GetObject("metroLinkWebsite.Image")));
			this.metroLinkWebsite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.metroLinkWebsite.Location = new System.Drawing.Point(153, 115);
			this.metroLinkWebsite.Name = "metroLinkWebsite";
			this.metroLinkWebsite.Size = new System.Drawing.Size(161, 23);
			this.metroLinkWebsite.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroLinkWebsite.TabIndex = 5;
			this.metroLinkWebsite.Text = "https://mijo-software.de";
			this.metroLinkWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroLinkWebsite.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroLinkWebsite, "Website");
			this.metroLinkWebsite.UseSelectable = true;
			// 
			// metroTextBoxDescription
			// 
			// 
			// 
			// 
			this.metroTextBoxDescription.CustomButton.Image = null;
			this.metroTextBoxDescription.CustomButton.Location = new System.Drawing.Point(224, 2);
			this.metroTextBoxDescription.CustomButton.Name = "";
			this.metroTextBoxDescription.CustomButton.Size = new System.Drawing.Size(103, 103);
			this.metroTextBoxDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBoxDescription.CustomButton.TabIndex = 1;
			this.metroTextBoxDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBoxDescription.CustomButton.UseSelectable = true;
			this.metroTextBoxDescription.CustomButton.Visible = false;
			this.metroTextBoxDescription.Lines = new string[0];
			this.metroTextBoxDescription.Location = new System.Drawing.Point(3, 181);
			this.metroTextBoxDescription.MaxLength = 9999999;
			this.metroTextBoxDescription.Multiline = true;
			this.metroTextBoxDescription.Name = "metroTextBoxDescription";
			this.metroTextBoxDescription.PasswordChar = '\0';
#pragma warning disable CS0618 // Typ oder Element ist veraltet
			this.metroTextBoxDescription.PromptText = "description here";
#pragma warning restore CS0618 // Typ oder Element ist veraltet
			this.metroTextBoxDescription.ReadOnly = true;
			this.metroTextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBoxDescription.SelectedText = "";
			this.metroTextBoxDescription.SelectionLength = 0;
			this.metroTextBoxDescription.SelectionStart = 0;
			this.metroTextBoxDescription.ShortcutsEnabled = true;
			this.metroTextBoxDescription.Size = new System.Drawing.Size(330, 108);
			this.metroTextBoxDescription.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroTextBoxDescription.TabIndex = 6;
			this.metroTextBoxDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroToolTip.SetToolTip(this.metroTextBoxDescription, "Description");
			this.metroTextBoxDescription.UseSelectable = true;
			this.metroTextBoxDescription.WaterMark = "description here";
			this.metroTextBoxDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBoxDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroCheckBoxApplyNumbers
			// 
			this.metroCheckBoxApplyNumbers.AutoSize = true;
			this.metroCheckBoxApplyNumbers.Checked = true;
			this.metroCheckBoxApplyNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.metroCheckBoxApplyNumbers.Location = new System.Drawing.Point(3, 18);
			this.metroCheckBoxApplyNumbers.Name = "metroCheckBoxApplyNumbers";
			this.metroCheckBoxApplyNumbers.Size = new System.Drawing.Size(104, 15);
			this.metroCheckBoxApplyNumbers.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroCheckBoxApplyNumbers.TabIndex = 4;
			this.metroCheckBoxApplyNumbers.Text = "Apply numbers";
			this.metroCheckBoxApplyNumbers.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBoxApplyNumbers.UseSelectable = true;
			// 
			// metroCheckBoxRemoveMultipleSpaces
			// 
			this.metroCheckBoxRemoveMultipleSpaces.AutoSize = true;
			this.metroCheckBoxRemoveMultipleSpaces.Location = new System.Drawing.Point(3, 39);
			this.metroCheckBoxRemoveMultipleSpaces.Name = "metroCheckBoxRemoveMultipleSpaces";
			this.metroCheckBoxRemoveMultipleSpaces.Size = new System.Drawing.Size(151, 15);
			this.metroCheckBoxRemoveMultipleSpaces.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroCheckBoxRemoveMultipleSpaces.TabIndex = 5;
			this.metroCheckBoxRemoveMultipleSpaces.Text = "Remove multiple spaces";
			this.metroCheckBoxRemoveMultipleSpaces.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBoxRemoveMultipleSpaces.UseSelectable = true;
			// 
			// metroCheckBoxShowStatisticAfterFinish
			// 
			this.metroCheckBoxShowStatisticAfterFinish.AutoSize = true;
			this.metroCheckBoxShowStatisticAfterFinish.Location = new System.Drawing.Point(3, 60);
			this.metroCheckBoxShowStatisticAfterFinish.Name = "metroCheckBoxShowStatisticAfterFinish";
			this.metroCheckBoxShowStatisticAfterFinish.Size = new System.Drawing.Size(154, 15);
			this.metroCheckBoxShowStatisticAfterFinish.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroCheckBoxShowStatisticAfterFinish.TabIndex = 6;
			this.metroCheckBoxShowStatisticAfterFinish.Text = "Show statistic after finish";
			this.metroCheckBoxShowStatisticAfterFinish.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroCheckBoxShowStatisticAfterFinish.UseSelectable = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 423);
			this.Controls.Add(this.metroTabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Arabic Transcriptions (Metro)";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.metroTabPageOptions.ResumeLayout(false);
			this.metroTabPageOptions.PerformLayout();
			this.metroTabControl.ResumeLayout(false);
			this.metroTabPageTranscription.ResumeLayout(false);
			this.metroTabPageTranscription.PerformLayout();
			this.metroTabPageAbout.ResumeLayout(false);
			this.metroTabPageAbout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Components.MetroToolTip metroToolTip;
		private MetroFramework.Controls.MetroTabControl metroTabControl;
		private MetroFramework.Controls.MetroTabPage metroTabPageTranscription;
		private MetroFramework.Controls.MetroTabPage metroTabPageOptions;
		private MetroFramework.Controls.MetroTabPage metroTabPageAbout;
		private MetroFramework.Controls.MetroButton metroButtonTranscribe;
		private MetroFramework.Controls.MetroTextBox metroTextBoxArabic;
		private MetroFramework.Controls.MetroLabel metroLabelArabic;
		private MetroFramework.Controls.MetroLabel metroLabelResult;
		private MetroFramework.Controls.MetroTextBox metroTextBoxResult;
		private MetroFramework.Controls.MetroUserControl metroUserControl1;
		private MetroFramework.Controls.MetroLabel metroLabelCompany;
		private MetroFramework.Controls.MetroLabel metroLabelCopyright;
		private MetroFramework.Controls.MetroLabel metroLabelVersion;
		private MetroFramework.Controls.MetroLabel metroLabelProductName;
		private MetroFramework.Controls.MetroLink metroLinkWebsite;
		private MetroFramework.Controls.MetroTextBox metroTextBoxDescription;
		private MetroFramework.Controls.MetroCheckBox metroCheckBoxApplyNumbers;
		private MetroFramework.Controls.MetroCheckBox metroCheckBoxShowStatisticAfterFinish;
		private MetroFramework.Controls.MetroCheckBox metroCheckBoxRemoveMultipleSpaces;
	}
}

