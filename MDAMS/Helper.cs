using MetroFramework.Controls;
using System;
using System.Windows.Forms;

namespace MDAMS
{
    class Helper
    {
        public static bool WriteError(string errSubj, string errStackTrace)
        {
            try
            {
                using (var tw = new System.IO.StreamWriter(AppGlobalDatas.LogFileName, true))
                {
                    tw.WriteLine(
                        String.Format("\n[{1}] - Error: {0} \n\t{2}\n", errSubj, DateTime.Now, errStackTrace));
                    tw.Close();

                }

                return true;
            }
            catch (Exception exception)
            {
                AppGlobalDatas.CurrentError = exception.Message;
                AppGlobalDatas.CurrentErrorStackTrace = exception;
                return false;
            }
        }

        public static void ClearAll(MetroFramework.Forms.MetroForm form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(MetroTextBox) || control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
                else if (control.GetType() == typeof(MetroComboBox) || control.GetType() == typeof(ComboBox))
                {
                    if (control.GetType() == typeof(MetroComboBox))
                    {
                        MetroComboBox combo = (MetroComboBox)control;
                        combo.Text = "";
                        combo.Items.Clear();
                    }
                    else
                    {
                        ComboBox combo = (ComboBox)control;
                        combo.Text = "";
                        combo.Items.Clear();
                    }
                }
                else if (control.GetType() == typeof(MetroCheckBox) || control.GetType() == typeof(CheckBox))
                {
                    if (control.GetType() == typeof(MetroCheckBox))
                    {
                        MetroCheckBox chk = (MetroCheckBox)control;
                        chk.Checked = false;
                    }
                    else
                    {
                        CheckBox chk = (CheckBox)control;
                        chk.Checked = false;
                    }
                }
                else if (control.GetType() == typeof(MetroRadioButton) || control.GetType() == typeof(RadioButton))
                {
                    if (control.GetType() == typeof(MetroRadioButton))
                    {
                        MetroRadioButton radio = (MetroRadioButton)control;
                        radio.Checked = false;
                    }
                    else
                    {
                        RadioButton radio = (RadioButton)control;
                        radio.Checked = false;
                    }
                }
            }
        }

    }
}
