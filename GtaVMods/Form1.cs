using DarkUI.Collections;
using DarkUI.Config;
using DarkUI.Controls;
using DarkUI.Docking;
using DarkUI.Forms;
using DarkUI.Renderers;
using Newtonsoft.Json;

using System.Diagnostics;
using System.Text.RegularExpressions;

namespace GtaVMods
{
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool gta5 = false;
        string ModPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\gtavmods";
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(ModPath))
            {
                Directory.CreateDirectory(ModPath);
            };
            if (!Directory.Exists(ModPath+"\\1"))
            {
                Directory.CreateDirectory(ModPath + "\\1");
            };
            if (!File.Exists(ModPath+ "\\gtavmodsFolder.json"))
            {
                File.Create(ModPath + "\\gtavmodsFolder.json").Close();
            }
            if (!File.Exists(ModPath + "\\gtavmodsFile.json"))
            {
                File.Create(ModPath + "\\gtavmodsFile.json").Close();
            }
            if (!File.Exists(ModPath + "\\gta.json"))
            {
                File.Create(ModPath + "\\gta.json").Close();
            }
            if (!File.Exists(ModPath + "\\status.txt"))
            {
                File.Create(ModPath + "\\status.txt").Close();
                File.WriteAllText(ModPath + "\\status.txt", "0");
            }


            gtafolder.ReadOnly = true;
            modsfolder.Text = ModPath;
            modsfolder.Enabled = true;
            modsfolder.ReadOnly = true;
            modsfolderbutton.Enabled = false;
        }

        private void movemods(int type, string source, string newSource)

        {
            bool errorFolder = false;
            List<string> folder1 = new List<string>();
            String directoryName = newSource;
             DirectoryInfo dirInfo = new DirectoryInfo(directoryName);
             if (dirInfo.Exists == false)
                 Directory.CreateDirectory(directoryName);

            List<String> AllDirectory = Directory
                               .GetDirectories(source).ToList();

    
            foreach (string directory in AllDirectory)
            {
                DirectoryInfo mDirectory = new DirectoryInfo(directory);
                

                // to remove name collisions
                if (new DirectoryInfo(dirInfo + "\\" + mDirectory.Name).Exists == false)
                {
                    try
                    {
                        folder1.Add(dirInfo + "\\" + mDirectory.Name);
                        mDirectory.MoveTo(dirInfo + "\\" + mDirectory.Name);
                    } catch 
                    {
                        valuemod.Checked = true;
                        errorFolder = true;
                        DarkMessageBox.ShowError("Bir hata oluþtu [C_Directory_Error]", "UUPS!", DarkDialogButton.Ok);
                        File.WriteAllText(ModPath + "\\status.txt", "0");
                    }

                }
            }
           

            bool errorFile = false;
            List<string> files1 = new List<string>();
            List<String> AllFiles = Directory
                                .GetFiles(source).ToList();


             foreach (string file in AllFiles)
             {
                 FileInfo mFile = new FileInfo(file);
                 // to remove name collisions
                 if (new FileInfo(dirInfo + "\\" + mFile.Name).Exists == false)
                 {
                    try
                    {
                        files1.Add(dirInfo + "\\" + mFile.Name);

                        mFile.MoveTo(dirInfo + "\\" + mFile.Name);
                    }
                    catch
                    {
                        valuemod.Checked = true;
                        errorFile = true;
                        DarkMessageBox.ShowError("Bir hata oluþtu [C_Files_Error]", "UUPS!", DarkDialogButton.Ok);
                        File.WriteAllText(ModPath + "\\status.txt", "0");
                    }

                 }
             }
            if (type == 1 && errorFile == false && errorFolder == false)
            {
                string[] folder = folder1.ToList().ToArray();
                string xjson = JsonConvert.SerializeObject(folder);
                File.WriteAllText(ModPath + "\\gtavmodsFolder.json", xjson);

                string[] files = files1.ToList().ToArray();
                string json = JsonConvert.SerializeObject(files);
                File.WriteAllText(ModPath + "\\gtavmodsFile.json", json);


            }
        }
        private void movemods(string source, string newSource, bool json, bool folderC, bool fileC)

        {
            if (json == true)
            {
                string[] fileJson = File.ReadAllLines(ModPath + "\\gtavmodsFile.json").ToArray();
                string[] folderJson = File.ReadAllLines(ModPath + "\\gtavmodsFolder.json").ToArray();

                string dirInfo = newSource;

                if (fileC) {
                foreach (var item in fileJson)
                {
                    var a = Regex.Replace(item, @"[^A-Za-z0-9/\\,.: ]+|( )+", "$1");
                    var te = a.Split(",").ToList(); //.Replace("\\\\", "\\")

                    foreach (var t in te)
                    {
                            if (!string.IsNullOrEmpty(t))
                            {

                           
                        FileInfo mFile = new FileInfo(t);
                        // to remove name collisions
                        if (new FileInfo(dirInfo + "\\" + mFile.Name).Exists == false)
                        {
                                try
                                {
                                    mFile.MoveTo(dirInfo + "\\" + mFile.Name);
                                }
                                catch
                                {
                                    valuegta.Checked = true;
                                    DarkMessageBox.ShowError("Bir hata oluþtu [C_Files_Error_trans]", "UUPS!", DarkDialogButton.Ok);
                                    File.WriteAllText(ModPath + "\\status.txt", "1");
                                }
                            }
                        }

                    }

                }

            }
                if (folderC) { 
                foreach (var item in folderJson)
                {
                    var a = Regex.Replace(item, @"[^A-Za-z0-9/\\,.: ]+|( )+", "$1");
                    var te = a.Replace("\\\\", "\\").Split(",").ToList();
                    foreach (var t in te)
                    {
                            if (!string.IsNullOrEmpty(t))
                            {

                            
                        DirectoryInfo mDirectory = new DirectoryInfo(t);
                        // to remove name collisions
                        
                        if (new FileInfo(dirInfo + "\\" + mDirectory.Name).Exists == false)
                        {
                                try
                                {
                                    mDirectory.MoveTo(dirInfo + "\\" + mDirectory.Name);
                                }
                                catch
                                {
                                    valuegta.Checked = true;
                                    DarkMessageBox.ShowError("Bir hata oluþtu [C_Folder_Error_trans]", "UUPS!", DarkDialogButton.Ok);
                                    File.WriteAllText(ModPath + "\\status.txt", "1");
                                }
                                }

                            }

                    }

                }
                }

            }


        }
       /* private void gtafolders(string gtafiles, string filesx)
        {

            string[] files = Directory.GetDirectories(gtafiles);
            List<string> files1 = new List<string>();

            foreach (var file in files)
            {

                int i = 0;

                if (!file.EndsWith("gtavmodsFolder.json") && !file.EndsWith("status.txt"))
                {
                    files1.Add(file);
                };
                i++;
            }
            files = files1.ToList().ToArray();
            string json = JsonConvert.SerializeObject(files);
            File.WriteAllText(filesx, json);
        }

        private void gtafiles(string gtafiles, string filesx)
        {

            string[] files = Directory.GetFiles(gtafiles);
            List<string> files1 = new List<string>();

            foreach (var file in files)
            {
                
                int i = 0;
                
                if (!file.EndsWith("gtavmodsFile.json") && !file.EndsWith("status.txt"))
                {
                    files1.Add(file);
                };
                i++;
            }
            files = files1.ToList().ToArray();
            string json = JsonConvert.SerializeObject(files);
            File.WriteAllText(filesx, json);
        }*/
      private static bool foldercheck(string gtafolder)
        {
            bool b1 = false;
            string[] files = Directory.GetFiles(gtafolder);
            foreach (string file in files)
            {
                if (file.EndsWith("GTA5.exe"))
                {
                    b1 = true;
                    break;
                }
            }
            return b1;
        }

        private void gtafolderbutton_Click(object sender, EventArgs e)
        {
            using (var gtaFolderWindows = new FolderBrowserDialog())
            {
                DialogResult result = gtaFolderWindows.ShowDialog();
                 gta5 = false;
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(gtaFolderWindows.SelectedPath))
                {
                    gtafolder.Text = gtaFolderWindows.SelectedPath;
                    
                  gta5 = foldercheck(gtafolder.Text);

                    if (gta5 == true)
                    {
                        gtavalue.Visible = true;
                        gtavalue.Text = "Gta 5 Bulundu!";
                        gtavalue.ForeColor = Color.LightGreen;
                    } else
                    {
                        gtavalue.Visible = true;
                        gtavalue.Text = "Gta 5 Bulunamadý!";
                        gtavalue.ForeColor = Color.OrangeRed;
                    }
                    File.WriteAllText(ModPath + "\\gta.json", gtafolder.Text);

                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            bool checkGtaFolder = String.IsNullOrEmpty(gtafolder.Text);
            if (checkGtaFolder)
            {
                DarkMessageBox.ShowError("GTA Klasörü Boþ görünüyor?", "UUPS!");
                return;
            }
            okButton.Visible = false;

            gta5 = foldercheck(gtafolder.Text);
            bool statusCheck = File.ReadAllText(ModPath + "\\status.txt").ToString() == "1";
            bool statusFolder = File.ReadAllText(ModPath + "\\gtavmodsFolder.json").ToString() != "";
            bool statusFile = File.ReadAllText(ModPath + "\\gtavmodsFile.json").ToString() != "";
            bool gtachecks = File.ReadAllText(ModPath + "\\gta.json").ToString() != "";
            // bool allStatus = (statusCheck == "1") && (!statusFile || !statusFolder);
            //rkMessageBox.ShowWarning(statusCheck.ToString(), "Dark UI Example");
           
 if (statusCheck && !checkGtaFolder)
            {
                File.WriteAllText(ModPath + "\\gta.json", gtafolder.Text);
                File.WriteAllText(ModPath + "\\status.txt", "0");
                
                bool statusFolder1 = false;
                bool statusFile1 = false;
                if (statusFolder)
                {
                    statusFolder1 = true;
                }
                if (statusFile)
                {
                    statusFile1 = true;
                }
                movemods(gtafolder.Text, ModPath + "\\1", true, statusFolder1, statusFile1);
                
            }
            else if (!statusCheck && (gta5 == true || gtachecks == true) && !checkGtaFolder)
            {
                File.WriteAllText(ModPath + "\\gta.json", gtafolder.Text);
                File.WriteAllText(ModPath + "\\status.txt", "1");
                movemods(1, ModPath + "\\1", gtafolder.Text);

            }
           
            statusCheck = false;
            statusCheck = true;
            statusCheck = File.ReadAllText(ModPath + "\\status.txt").ToString() == "1";
            if (statusCheck)
            {
                valuegta.Checked = true;
            }
            else if (!statusCheck)
            {
                valuemod.Checked = true;
            }
                okButton.Visible = true;

        }

        

        private void okButton_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            if (File.ReadAllText(ModPath + "\\status.txt").ToString() == "1")
            {
                valuegta.Checked = true;
                //gtafolder.Enabled = false;
                gtafolder.ReadOnly = true;
                gtafolderbutton.Enabled = false;
                gtafolder.Text = File.ReadAllText(ModPath + "\\gta.json").ToString();

                //    gta5 = true;
            }
            if (File.ReadAllText(ModPath + "\\status.txt").ToString() == "0")
            {
                valuemod.Checked = true;
                gtafolder.Text = File.ReadAllText(ModPath + "\\gta.json").ToString();
            }
            if (!String.IsNullOrEmpty(gtafolder.Text))
            {
                gta5 = foldercheck(gtafolder.Text);

                if (gta5 == true)
                {
                    gtavalue.Visible = true;
                    gtavalue.Text = "Gta 5 Bulundu!";
                    gtavalue.ForeColor = Color.LightGreen;
                }
                else
                {
                    gtavalue.Visible = true;
                    gtavalue.Text = "Gta 5 Bulunamadý!";
                    gtavalue.ForeColor = Color.OrangeRed;
                }
            }
        }


        private void valuegta_CheckedChanged(object sender, EventArgs e)
        {
            if (valuegta.Checked)
            {
                okButton.Text = "Mod Klasörüne taþý"; 
                gtafolderbutton.Enabled = false;
            }
        }

        private void valuemod_CheckedChanged(object sender, EventArgs e)
        {
            okButton.Text = "GTA taþý";
            gtafolderbutton.Enabled = true;
        }
    }

}