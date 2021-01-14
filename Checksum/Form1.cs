using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography;

namespace Checksum
{
    public partial class Form1 : Form
    {
        string fileLocation;
        string[] args;
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            args = Environment.GetCommandLineArgs();
           
            
            
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //MessageBox.Show(files);
            fileLocation = files[0];
            Hash(fileLocation);
            lbl_file.Text = Path.GetFileName(fileLocation);
        }
        private void Open(string loc)
        {
            File.Open(loc, FileMode.Open);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            AddRightClickMenu("Checksum", "Checksum this file", Application.ExecutablePath + " %1");
            if (args.Count() > 1)
            {
                fileLocation = args[1];
                Hash(fileLocation);

                lbl_file.Text = Path.GetFileName(fileLocation);
            } else {
                fileLocation = "";
            }
            
        }

        private void Hash(string loc)
        {
            //MessageBox.Show(loc);
            try
            {
                byte[] by = File.ReadAllBytes(loc);

                //MD5 Hash
                var md5 = MD5.Create();
                md5.ComputeHash(by);
                txt_MD5.Text = BitConverter.ToString(md5.ComputeHash(by)).Replace("-", "").ToLower();

                //SHA1
                var sha1 = SHA1.Create();
                md5.ComputeHash(by);
                txt_SHA1.Text = BitConverter.ToString(sha1.ComputeHash(by)).Replace("-", "").ToLower();

                //SHA256
                var sha256 = SHA256.Create();
                md5.ComputeHash(by);
                txt_SHA256.Text = BitConverter.ToString(sha256.ComputeHash(by)).Replace("-", "").ToLower();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

        private bool AddRightClickMenu(string MenuName, string MenuDescription, string MenuCommand)
        {
            bool ret = false;
            if (Registry.ClassesRoot.OpenSubKey("*").OpenSubKey("shell").OpenSubKey(MenuName) != null)
                return true;
            
            RegistryKey rkey = Registry.ClassesRoot.OpenSubKey("*").OpenSubKey("shell", true);
            if (rkey != null)
            {
                try
                {
                    string strkey = MenuName + "\\command";
                    RegistryKey subky = rkey.CreateSubKey(strkey);
                    if (subky != null)
                    {
                        subky.SetValue("", MenuCommand);
                        subky.Close();
                        subky = rkey.OpenSubKey(MenuName, true);
                        if (subky != null)
                        {
                            subky.SetValue("", MenuDescription);
                            subky.Close();
                        }
                        ret = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please run this app in Administrator", ex.Message);
                }
                rkey.Close();
            }
            Application.Exit();
            return ret;
        }  
    }
}
