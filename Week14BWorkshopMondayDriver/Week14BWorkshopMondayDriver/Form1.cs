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

namespace Week14BWorkshopMondayDriver
{
    public partial class Form1 : Form
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        public Form1()
        {
            InitializeComponent();
            driverComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DriveInfo driver in allDrives)
            {
                driverComboBox.Items.Add(driver.Name.ToString() + "    "+ driver.DriveType.ToString());
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (dirListBox.SelectedIndex < 0 || !dirListBox.SelectedItem.ToString().EndsWith(".txt"))
            {
                DirectoryInfo selectedDirectory = new DirectoryInfo(pathTextBox.Text + dirListBox.SelectedItem.ToString());
                pathTextBox.Text = pathTextBox.Text + dirListBox.SelectedItem.ToString();
                dirListBox.Items.Clear();
                foreach (DirectoryInfo dir in selectedDirectory.GetDirectories())
                {
                    dirListBox.Items.Add(@"\" + dir.Name);
                }
                foreach (FileInfo file in selectedDirectory.GetFiles())
                {
                    if (file.Name.EndsWith(".txt"))
                    {
                        dirListBox.Items.Add(@"\" + file.Name);
                    }
                }
            }
            else
            {
                string text = File.ReadAllText(pathTextBox.Text + dirListBox.SelectedItem.ToString());
                MessageBox.Show(text);
            }

        }

        private void driverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox.Items.Clear();
            DriveInfo selectedDriver = allDrives[driverComboBox.SelectedIndex];
            pathTextBox.Text = selectedDriver.RootDirectory.ToString();
            if (selectedDriver.DriveType != DriveType.CDRom)
            {
                DirectoryInfo selectedDriverDirectory = new DirectoryInfo(selectedDriver.RootDirectory.ToString());
                foreach (DirectoryInfo dir in selectedDriverDirectory.GetDirectories())
                {
                    dirListBox.Items.Add(dir.Name);
                }
                foreach (FileInfo file in selectedDriverDirectory.GetFiles())
                {
                    if (file.Name.EndsWith(".txt"))
                    {
                        dirListBox.Items.Add(file.Name);
                    }
                }
                
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            FileInfo deleteFile = new FileInfo(pathTextBox.Text + dirListBox.SelectedItem.ToString());
            deleteFile.Delete();
            dirListBox.Items.Remove(dirListBox.SelectedItem);
            MessageBox.Show("File Deleted.");
        }
    }
}
