using System;
using MijoSoftware.AssemblyInformation;
using ArabicTranscriptionsMetro.Properties;

namespace ArabicTranscriptionsMetro
{
	public partial class MainForm : MetroFramework.Forms.MetroForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			metroLabelProductName.Text = AssemblyInfo.AssemblyProduct;
			metroLabelVersion.Text = AssemblyInfo.AssemblyVersion;
			metroLabelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			metroLabelCompany.Text = AssemblyInfo.AssemblyCompany;
			metroTextBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}

		private void MetroButtonTranscribe_Click(object sender, EventArgs e)
		{
			metroTextBoxResult.Text = metroTextBoxArabic.Text;
			if (metroCheckBoxApplyNumbers.Checked)
			{
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicZero, newValue: Resources.latinZero);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicOne, newValue: Resources.latinOne);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicTwo, newValue: Resources.latinTwo);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicThree, newValue: Resources.latinThree);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicFour, newValue: Resources.latinFour);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicFive, newValue: Resources.latinFive);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicSix, newValue: Resources.latinSix);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicSeven, newValue: Resources.latinSeven);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicEight, newValue: Resources.latinEight);
				metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.arabicNine, newValue: Resources.latinNine);
			}

			if (metroCheckBoxRemoveMultipleSpaces.Checked)
			{
				while (metroTextBoxResult.Text.Contains(value: Resources.doubleSpace))
				{
					metroTextBoxResult.Text = metroTextBoxResult.Text.Replace(oldValue: Resources.doubleSpace, newValue: Resources.space);
				}
			}
			if (metroCheckBoxShowStatisticAfterFinish.Checked)
			{
				//OutputStatisticAsMessageBox();
			}
		}
	}
}
