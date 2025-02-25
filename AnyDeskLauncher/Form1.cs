using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyDeskLauncher
{
    public partial class Form1: Form
    {
        private string jsonFile = "anydesk_data.json";
        private Dictionary<string, string> anyDeskEntries = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string alias = txtAlias.Text.Trim();
            string anydeskID = txtAnyDeskID.Text.Trim();

            if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(anydeskID))
            {
                MessageBox.Show("Both Alias and AnyDesk ID are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            anyDeskEntries[alias] = anydeskID; // Store in Dictionary
            SaveData();
            LoadList();
            txtAlias.Clear();
            txtAnyDeskID.Clear();
        }
        private void LoadList()
        {
            lstAnyDesk.Items.Clear();
            foreach (var entry in anyDeskEntries.Keys)
            {
                lstAnyDesk.Items.Add(entry);
            }
        }
        private void SaveData()
        {
            File.WriteAllText(jsonFile, JsonSerializer.Serialize(anyDeskEntries));
        }
        private void LoadData()
        {
            if (File.Exists(jsonFile))
            {
                anyDeskEntries = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(jsonFile)) ?? new Dictionary<string, string>();
                LoadList();
            }
        }
    }
}
