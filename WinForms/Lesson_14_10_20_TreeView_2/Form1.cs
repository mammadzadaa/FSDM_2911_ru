using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                        TreeNode node = new TreeNode(Path.GetFileName(dir));
                        node.Tag = dir;
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
                                TreeNode subnode = new TreeNode(Path.GetFileName(subdir));
                                subnode.Tag = subdir;
                                node.Nodes.Add(subnode);
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
                            var subdirectories = Directory.GetDirectories(node.Tag as string);
                            foreach (var item in subdirectories)
                            {
                                TreeNode subsubnode = new TreeNode(Path.GetFileName(item));
                                subsubnode.Tag = item;
                                node.Nodes.Add(subsubnode);
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {

                        }             
                    }               
                }
            }

        private void folderTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var fullPath = e.Node.Tag as string;
            pathTextBox.Text = fullPath;
            try
            {
                AddingElements(fullPath);
            }
            catch (UnauthorizedAccessException)
            {

            }
        }

        private void AddingElements(string fullPath)
        {
            elementsListView.Clear();
            var allDirectories = Directory.GetDirectories(fullPath);

            foreach (var dir in allDirectories)
            {
                var item = new ListViewItem(Path.GetFileName(dir));
                item.Tag = dir;
                item.ImageIndex = 0;
                elementsListView.Items.Add(item);
            }

            var allFiles = Directory.GetFiles(fullPath);

            foreach (var file in allFiles)
            {
                var item = new ListViewItem(Path.GetFileName(file));
                item.Tag = file;
                item.ImageIndex = 1;
                elementsListView.Items.Add(item);
            }
        }

        private void elementsListView_ItemActivate(object sender, EventArgs e)
        {
            var fullPath = elementsListView.SelectedItems[0].Tag as string;
            if (Path.HasExtension(fullPath))
            {
                Process.Start(fullPath);
            }
            else
            {
                try
                {
                    pathTextBox.Text = fullPath;
                    AddingElements(fullPath);
                }
                catch (UnauthorizedAccessException)
                {

                }
                
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;
            var parentPath = path.Substring(0, path.LastIndexOf(@"\"));
            pathTextBox.Text = parentPath;
            AddingElements(parentPath);

        }
    }
    }
