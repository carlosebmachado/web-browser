using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            foreach (var setting in Settings.data)
            {
                dgvSettings.Rows.Add(setting.Key, setting.Value);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSettings.Rows)
            {
                Settings.Set(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            }
            Close();
        }
    }
}
