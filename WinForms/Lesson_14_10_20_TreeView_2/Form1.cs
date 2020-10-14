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

namespace Lesson_14_10_20_TreeView_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var directories = Directory.GetDirectories(@"C:\","*",SearchOption.TopDirectoryOnly);
            foreach (var dir in directories)
            {
                try
                {
                    DirectoryInfo info = new DirectoryInfo(dir);

                    if (info.Attributes != FileAttributes.Hidden)
                    {
                        TreeNode node = new TreeNode(dir);
                        folderTreeView.Nodes.Add(node);
                        if (info.GetDirectories().Length != 0)
                        {
                            node.ImageIndex = 1;
                        }
                        var subdirectories = Directory.GetDirectories(dir);
                        foreach (var subdir in subdirectories)
                        {
                            info = new DirectoryInfo(subdir);
                            if (info.Attributes != FileAttributes.Hidden)
                            {
                                node.Nodes.Add(subdir);
                            }
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                   
                }
                
              
               
            }
        }

        private void folderTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
                foreach (var subnode in e.Node.Nodes)
                {
                    var node = subnode as TreeNode;
                    if (node.Nodes.Count == 0)
                    {
                        try
                        {
                            var subdirectories = Directory.GetDirectories(node.Text);
                            foreach (var item in subdirectories)
                            {
                                node.Nodes.Add(item);
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {

                        }
                    
                    }                  

                }
            }
            
            
           
        }
    }
