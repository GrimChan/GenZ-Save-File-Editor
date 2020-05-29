using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Generation_Zero_Save_File_Modder
{
    public partial class Form1 : Form
    {
        #region Structs

        public struct Item
        {
            public string ID;
            public string HASH;
            public string AMOUNT;
            public string NAME;

            public Item(string id, string hash, string amount, string name) : this()
            {
                ID = id;
                HASH = hash;
                AMOUNT = amount;
                NAME = name;
            }
        }

        #endregion


        #region Variables

        public int weaponSwapIndex;
        public int inventorySwapIndex;
        public int weaponSwapValue;
        public int inventorySwapValue;

        public int attachmentSwapIndex;
        public int inventoryAttachmentSwapIndex;
        public int attachmentSwapValue;
        public int inventoryAttachmentSwapValue;

        public string saveFileName;
        public int saveFileIndex = 1;

        public string saveFileName2;
        public string saveTxtPath;

        public List<Item> items = new List<Item>();

        #endregion


        #region Program Initilization

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string x = Resource1.WeaponNames;
            string[] y = x.Split('\n');
            foreach (string s in y)
            {
                weaponSwapBox.Items.Add(s);
                inventorySwapBox.Items.Add(s);
            }

            string z = Resource1.Attachments;
            string[] h = z.Split('\n');
            foreach (string s in h)
            {
                attachmentCombo.Items.Add(s.Remove(s.IndexOf(','), s.Length - s.IndexOf(',')));
                inventoryAttachmentCombo.Items.Add(s.Remove(s.IndexOf(','), s.Length - s.IndexOf(',')));
            }

            weaponSwapValue = Decimal.ToInt32(weaponSwapQuality.Value);
            inventorySwapValue = Decimal.ToInt32(inventorySwapQuality.Value);

            attachmentSwapValue = Decimal.ToInt32(weaponSwapQuality.Value);
            inventoryAttachmentSwapValue = Decimal.ToInt32(inventorySwapQuality.Value);

            saveSlotTicker.Value = 1;

            MessageBox.Show("Please Close This Program Before Opening Gen Z Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFile2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveFileName = openFileDialog1.FileName;
            savePathLabel.Text = openFileDialog1.FileName;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            saveFileName2 = openFileDialog2.FileName;
            savePathLabel2.Text = openFileDialog2.FileName;
            saveTxtPath = File.ReadAllText(savePathLabel2.Text);

            string[] lines = saveTxtPath.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("                      ID:"))
                {
                    string idLine = lines[i + 1];
                    string hashLine = lines[i + 3];
                    string amountLine = lines[i + 5];

                    items.Add(new Item(idLine, hashLine, amountLine, "-Null-"));
                }
            }

            foreach (Item item in items)
            {
                equipmentSelectorCombo.Items.Add(item.ID.Trim());
            }
        }

        #endregion


        #region Weapon Replacer

        private void weaponSwapBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            weaponSwapIndex = weaponSwapBox.SelectedIndex;

            if (weaponSwapIndex == 1 || weaponSwapIndex == 3 || weaponSwapIndex == 5 || weaponSwapIndex == 9 || weaponSwapIndex == 11 || weaponSwapIndex == 13 || weaponSwapIndex == 15)
            {
                weaponSwapQuality.Maximum = 6;
            }
            else
            {
                weaponSwapQuality.Maximum = 5;
            }

            switch (weaponSwapIndex)
            {
                case 0:
                    weaponImage.Image = Resource1._1;
                    break;
                case 1:
                    weaponImage.Image = Resource1._2;
                    break;
                case 2:
                    weaponImage.Image = Resource1._3;
                    break;
                case 3:
                    weaponImage.Image = Resource1._4;
                    break;
                case 4:
                    weaponImage.Image = Resource1._5;
                    break;
                case 5:
                    weaponImage.Image = Resource1._6;
                    break;
                case 6:
                    weaponImage.Image = Resource1._7;
                    break;
                case 7:
                    weaponImage.Image = Resource1._8;
                    break;
                case 8:
                    weaponImage.Image = Resource1._9;
                    break;
                case 9:
                    weaponImage.Image = Resource1._10;
                    break;
                case 10:
                    weaponImage.Image = Resource1._11;
                    break;
                case 11:
                    weaponImage.Image = Resource1._12;
                    break;
                case 12:
                    weaponImage.Image = Resource1._13;
                    break;
                case 13:
                    weaponImage.Image = Resource1._14;
                    break;
                case 14:
                    weaponImage.Image = Resource1._15;
                    break;
                case 15:
                    weaponImage.Image = Resource1._16;
                    break;
                default:
                    break;
            }
        }

        private void inventorySwapBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventorySwapIndex = inventorySwapBox.SelectedIndex;

            if (inventorySwapIndex == 1 || inventorySwapIndex == 3 || inventorySwapIndex == 5 || inventorySwapIndex == 9 || inventorySwapIndex == 11 || inventorySwapIndex == 13 || inventorySwapIndex == 15)
            {
                inventorySwapQuality.Maximum = 6;
            }
            else
            {
                inventorySwapQuality.Maximum = 5;
            }

            switch (inventorySwapIndex)
            {
                case 0:
                    inventoryWeaponImage.Image = Resource1._1;
                    break;
                case 1:
                    inventoryWeaponImage.Image = Resource1._2;
                    break;
                case 2:
                    inventoryWeaponImage.Image = Resource1._3;
                    break;
                case 3:
                    inventoryWeaponImage.Image = Resource1._4;
                    break;
                case 4:
                    inventoryWeaponImage.Image = Resource1._5;
                    break;
                case 5:
                    inventoryWeaponImage.Image = Resource1._6;
                    break;
                case 6:
                    inventoryWeaponImage.Image = Resource1._7;
                    break;
                case 7:
                    inventoryWeaponImage.Image = Resource1._8;
                    break;
                case 8:
                    inventoryWeaponImage.Image = Resource1._9;
                    break;
                case 9:
                    inventoryWeaponImage.Image = Resource1._10;
                    break;
                case 10:
                    inventoryWeaponImage.Image = Resource1._11;
                    break;
                case 11:
                    inventoryWeaponImage.Image = Resource1._12;
                    break;
                case 12:
                    inventoryWeaponImage.Image = Resource1._13;
                    break;
                case 13:
                    inventoryWeaponImage.Image = Resource1._14;
                    break;
                case 14:
                    inventoryWeaponImage.Image = Resource1._15;
                    break;
                case 15:
                    inventoryWeaponImage.Image = Resource1._16;
                    break;
                default:
                    break;
            }
        }

        private void weaponSwapQuality_ValueChanged(object sender, EventArgs e)
        {
            weaponSwapValue = decimal.ToInt32(weaponSwapQuality.Value);

            switch (weaponSwapValue)
            {
                case 1:
                    weaponQuality.Image = Resource1._1_crown;
                    break;
                case 2:
                    weaponQuality.Image = Resource1._2_crown;
                    break;
                case 3:
                    weaponQuality.Image = Resource1._3_crown;
                    break;
                case 4:
                    weaponQuality.Image = Resource1._4_crown;
                    break;
                case 5:
                    weaponQuality.Image = Resource1._5_crown;
                    break;
                case 6:
                    weaponQuality.Image = Resource1._6_crown;
                    break;
                default:
                    break;
            }
        }

        private void inventorySwapQuality_ValueChanged(object sender, EventArgs e)
        {
            inventorySwapValue = decimal.ToInt32(inventorySwapQuality.Value);

            switch (inventorySwapValue)
            {
                case 1:
                    inventoryQuality.Image = Resource1._1_crown;
                    break;
                case 2:
                    inventoryQuality.Image = Resource1._2_crown;
                    break;
                case 3:
                    inventoryQuality.Image = Resource1._3_crown;
                    break;
                case 4:
                    inventoryQuality.Image = Resource1._4_crown;
                    break;
                case 5:
                    inventoryQuality.Image = Resource1._5_crown;
                    break;
                case 6:
                    inventoryQuality.Image = Resource1._6_crown;
                    break;
                default:
                    break;
            }
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            if (saveFileName.Length > 0)
            {
                if (weaponSwapQuality.Value < inventorySwapQuality.Value)
                {
                    MessageBox.Show(
                        "The weapon you are going to recieve is of a lower value than the one you are trading it for",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                int weaponIndex;
                int inventoryIndex;

                weaponIndex = weaponSwapIndex * 7 + weaponSwapValue;
                inventoryIndex = inventorySwapIndex * 7 + inventorySwapValue;

                string x = Resource1.WeaponIDs;
                string[] y = x.Split(',', '\n');

                uint hash1 = uint.Parse(y[weaponIndex]);
                string hexString1 = hash1.ToString("X");
                uint hex1 = uint.Parse(hexString1, System.Globalization.NumberStyles.HexNumber);

                uint hash2 = uint.Parse(y[inventoryIndex]);
                string hexString2 = hash2.ToString("X");
                uint hex2 = uint.Parse(hexString2, System.Globalization.NumberStyles.HexNumber);

                List<int> hexLocations = new List<int>();

                Stream f = File.OpenRead(saveFileName);
                BinaryReader br = new BinaryReader(f);
                for (int i = 0; i < f.Length - 10; i++)
                {
                    f.Seek(i, SeekOrigin.Begin);
                    if (br.ReadUInt32() == hex2)
                    {
                        hexLocations.Add(i);
                    }
                }
                br.Close();

                BinaryWriter bw = new BinaryWriter(File.Open(saveFileName, FileMode.Open, FileAccess.ReadWrite));
                bw.BaseStream.Position = hexLocations[0];
                bw.Write(hex1);
                bw.Flush();
                bw.Close();

                MessageBox.Show(
                        "Finished Processing The Weapon Swap",
                        "Finished",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
            }
        }

        #endregion


        #region Skill Editor

        private void resetSkills_Click(object sender, EventArgs e)
        {
            if (saveFileName.Length > 0)
            {
                string x = Resource1.Skills;
                string[] y = x.Split('\n');

                //y[index1] and y[index2]

                List<int> hexLocations = new List<int>();

                Int32 stopLocation = 0x00000000;
                Int32 startLocation = 0x00000000;

                int[] arraySize = new int[4];
                int[] arrayLocation = new int[4];

                int hits = 0;
                string skillTerm = "Skills:";

                string[] w = saveTxtPath.Split('\n');
                for (int i = 0; i < w.Length; i++)
                {
                    if (w[i].Contains(skillTerm))
                    {
                        string firstHit = w[i + 1];

                        string firstHitSub = firstHit.Remove(0, firstHit.IndexOf(':') + 1);

                        string main = firstHitSub.Remove(firstHitSub.IndexOf('('), firstHitSub.IndexOf(')') - firstHitSub.IndexOf('(') + 1);

                        arrayLocation[hits] = int.Parse(main);

                        string firstHit2 = w[i + 133];

                        string firstHitSub2 = firstHit2.Remove(0, firstHit2.IndexOf(':') + 1);

                        arraySize[hits] = int.Parse(firstHitSub2.Remove(firstHitSub2.IndexOf('('), firstHitSub2.Length - firstHitSub2.IndexOf('('))) - arrayLocation[hits];

                        hits++;
                    }
                }


                switch ((int)saveSlotTicker.Value)
                {
                    case 1:
                        string hexValue = arrayLocation[0].ToString("X");
                        startLocation = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                        string hexValue2 = arraySize[0].ToString("X");
                        stopLocation = startLocation + int.Parse(hexValue2, System.Globalization.NumberStyles.HexNumber);
                        break;
                    case 2:
                        string hexValue3 = arrayLocation[1].ToString("X");
                        startLocation = int.Parse(hexValue3, System.Globalization.NumberStyles.HexNumber);
                        string hexValue4 = arraySize[1].ToString("X");
                        stopLocation = startLocation + int.Parse(hexValue4, System.Globalization.NumberStyles.HexNumber);
                        break;
                    case 3:
                        string hexValue5 = arrayLocation[2].ToString("X");
                        startLocation = int.Parse(hexValue5, System.Globalization.NumberStyles.HexNumber);
                        string hexValue6 = arraySize[2].ToString("X");
                        stopLocation = startLocation + int.Parse(hexValue6, System.Globalization.NumberStyles.HexNumber);
                        break;
                    case 4:
                        string hexValue7 = arrayLocation[3].ToString("X");
                        startLocation = int.Parse(hexValue7, System.Globalization.NumberStyles.HexNumber);
                        string hexValue8 = arraySize[3].ToString("X");
                        stopLocation = startLocation + int.Parse(hexValue8, System.Globalization.NumberStyles.HexNumber);
                        break;
                }

                Stream f = File.OpenRead(saveFileName);
                BinaryReader br = new BinaryReader(f);
                foreach (string o in y)
                {
                    uint hash2 = uint.Parse(o);
                    string hexString2 = hash2.ToString("X");
                    uint hex2 = uint.Parse(hexString2, System.Globalization.NumberStyles.HexNumber);

                    for (int i = startLocation; i < stopLocation; i++)
                    {
                        f.Seek(i, SeekOrigin.Begin);
                        if (br.ReadUInt32() == hex2)
                        {
                            hexLocations.Add(i);
                        }
                    }
                }
                br.Close();
                f.Close();

                BinaryWriter bw = new BinaryWriter(File.Open(saveFileName, FileMode.Open, FileAccess.ReadWrite));
                foreach (int hexLocal in hexLocations)
                {
                    bw.BaseStream.Position = hexLocal;
                    bw.Write(0x00000000);
                }
                bw.Flush();
                bw.Close();

                BinaryWriter bw2 = new BinaryWriter(File.Open(saveFileName, FileMode.Open, FileAccess.ReadWrite));
                bw2.BaseStream.Position = startLocation + 704;
                bw2.Write((int)skillPoints.Value);
                bw2.Close();
                MessageBox.Show("Your skills have been reset!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


        #region Attachment Replacer

        private void attachmentSwapButton_Click(object sender, EventArgs e)
        {
            if (saveFileName.Length > 0)
            {
                if (attachmentQuality.Value < inventoryAttachmentQuality.Value)
                {
                    MessageBox.Show(
                        "The weapon you are going to recieve is of a worse value than the one you are trading it for",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                int attachmentIndex;
                int inventoryAttachmentIndex;

                attachmentIndex = attachmentSwapIndex * 6 + attachmentSwapValue;
                inventoryAttachmentIndex = inventoryAttachmentSwapIndex * 6 + inventoryAttachmentSwapValue;

                string x = Resource1.Attachments;
                string[] y = x.Split(',', '\n');

                uint hash1 = uint.Parse(y[attachmentIndex]);
                string hexString1 = hash1.ToString("X");
                uint hex1 = uint.Parse(hexString1, System.Globalization.NumberStyles.HexNumber);

                uint hash2 = uint.Parse(y[inventoryAttachmentIndex]);
                string hexString2 = hash2.ToString("X");
                uint hex2 = uint.Parse(hexString2, System.Globalization.NumberStyles.HexNumber);

                List<int> hexLocations = new List<int>();

                Stream f = File.OpenRead(saveFileName);
                BinaryReader br = new BinaryReader(f);
                for (int i = 0; i < f.Length - 10; i++)
                {
                    f.Seek(i, SeekOrigin.Begin);
                    if (br.ReadUInt32() == hex2)
                    {
                        hexLocations.Add(i);
                    }
                }
                br.Close();

                BinaryWriter bw = new BinaryWriter(File.Open(saveFileName, FileMode.Open, FileAccess.ReadWrite));
                bw.BaseStream.Position = hexLocations[0];
                bw.Write(hex1);
                bw.Flush();
                bw.Close();

                MessageBox.Show(
                        "Finished Processing The Attachment Swap",
                        "Finished",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
            }
        }

        private void attachmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachmentSwapIndex = attachmentCombo.SelectedIndex;

            attachmentQuality.Maximum = 5;

            if (attachmentCombo.SelectedIndex >= 32) 
            {
                attachmentQuality.Maximum = 1;
            }
        }

        private void inventoryAttachmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventoryAttachmentSwapIndex = inventoryAttachmentCombo.SelectedIndex;

            inventoryAttachmentQuality.Maximum = 5;
        }

        private void inventoryAttachmentQuality_ValueChanged(object sender, EventArgs e)
        {
            inventoryAttachmentSwapValue = decimal.ToInt32(inventoryAttachmentQuality.Value);
        }

        private void attachmentQuality_ValueChanged(object sender, EventArgs e)
        {
            attachmentSwapValue = decimal.ToInt32(attachmentQuality.Value);
        }


        #endregion


        #region Item Editor

        private void equipmentSelectorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipmentHashBox.Text = items[equipmentSelectorCombo.SelectedIndex].HASH.Remove(items[equipmentSelectorCombo.SelectedIndex].HASH.IndexOf('#')).Trim();
            equipmentAmountBox.Text = items[equipmentSelectorCombo.SelectedIndex].AMOUNT.Remove(items[equipmentSelectorCombo.SelectedIndex].AMOUNT.IndexOf('#')).Trim();
            equipmentNameBox.Text = items[equipmentSelectorCombo.SelectedIndex].NAME;

            string x = Resource1.itemHashes;
            string[] y = x.Split('\r');
            string z = Resource1.itemNames;
            string[] c = z.Split('\r');
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i].Contains(items[equipmentSelectorCombo.SelectedIndex].HASH.Remove(items[equipmentSelectorCombo.SelectedIndex].HASH.IndexOf('#')).Trim()))
                {
                    string name = c[i];
                    equipmentNameBox.Text = name;
                }
            }
        }

        private void changeInfo_Click(object sender, EventArgs e)
        {
            //Get info of item
            string trimmedAmount = items[equipmentSelectorCombo.SelectedIndex].AMOUNT.Substring(items[equipmentSelectorCombo.SelectedIndex].AMOUNT.LastIndexOf('(')).Trim('(', '\r', ')');
            
            uint hash1 = uint.Parse(items[equipmentSelectorCombo.SelectedIndex].AMOUNT.Remove(items[equipmentSelectorCombo.SelectedIndex].AMOUNT.IndexOf('#')).Trim());
            string hexString1 = hash1.ToString("X");
            uint originalAmount = uint.Parse(hexString1, System.Globalization.NumberStyles.HexNumber);

            uint amountLocation = Convert.ToUInt32(trimmedAmount, 16);

            uint hash3 = uint.Parse(equipmentAmountBox.Text);
            string hexString3 = hash3.ToString("X");
            uint newAmount = uint.Parse(hexString3, System.Globalization.NumberStyles.HexNumber);

            //Write new items new info to the right address
            BinaryWriter bw = new BinaryWriter(File.Open(saveFileName, FileMode.Open, FileAccess.ReadWrite));
            bw.BaseStream.Position = amountLocation;
            bw.Write(newAmount);
            bw.Flush();
            bw.Close();

            MessageBox.Show(
                        "Finished Processing The Item Change",
                        "Finished",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
        }

        #endregion
    }
}
