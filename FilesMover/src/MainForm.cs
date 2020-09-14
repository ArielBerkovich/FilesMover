using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FilesMover
{
    public partial class FilesMoverForm : Form
    {
        Thread diskOnKeyStatusObserver;
        Thread newFilesObserver;

        public FilesMoverForm()
        {
            InitializeComponent();
        }

        private void FilesMover_Load(object sender, EventArgs e)
        {
            initObservers();
            initComboBoxes();
        }

        private void initObservers()
        {
            diskOnKeyStatusObserver = new Thread(observeDiskOnKeyConnectionStatus);
            diskOnKeyStatusObserver.Start();

            newFilesObserver = new Thread(observeNewFilesAndUpdateComboBoxes);
            newFilesObserver.Start();
        }


        private void initComboBoxes()
        {
            ComboBoxHelper.initComboBoxWithLatestFiles(ref presCombobox, Constants.presentationsExtension);
            ComboBoxHelper.initComboBoxWithLatestFiles(ref docsComboBox, Constants.documentsExtension);
            ComboBoxHelper.initComboBoxWithLatestFiles(ref pdfComboBox, Constants.pdfExtension);
            ComboBoxHelper.initComboBoxWithLatestFiles(ref mp4ComboBox, Constants.mp4Extension);
        }

        override
        protected void OnClosed(EventArgs e)
        {
            diskOnKeyStatusObserver.Abort();
            newFilesObserver.Abort();

            diskOnKeyStatusObserver.Join();
            newFilesObserver.Join();
        }

        //Buttons:
        private void MovePresButton_Click(object sender, EventArgs e)
        {
            FilesUtils.copyToDiskOnKey(presCombobox,Constants.DOCUMENTS_FOLDER);
        }

        private void MoveDocButton_Click(object sender, EventArgs e)
        {
            FilesUtils.copyToDiskOnKey(docsComboBox, Constants.DOCUMENTS_FOLDER);
        }

        private void MovePdfButton_Click(object sender, EventArgs e)
        {
            FilesUtils.copyToDiskOnKey(pdfComboBox,Constants.DOCUMENTS_FOLDER);
        }

        private void MoveMp4Button_Click(object sender, EventArgs e)
        {
            FilesUtils.copyToDiskOnKey(mp4ComboBox, Constants.DOWNLOADS_FOLDER);
        }

        private void openDiskOnKeyButton_Click(object sender, EventArgs e)
        {
            FilesUtils.openDiskOnKeyInFileExplorer();
        }

        private void observeNewFilesAndUpdateComboBoxes()
        {
            while (true)
            {
                try
                {
                    presCombobox.Invoke((MethodInvoker)delegate
                    {
                        ComboBoxHelper.updateComboBox(Constants.presentationsExtension, ref presCombobox);
                    });

                    pdfComboBox.Invoke((MethodInvoker)delegate
                    {
                        ComboBoxHelper.updateComboBox(Constants.pdfExtension, ref pdfComboBox);
                    });

                    docsComboBox.Invoke((MethodInvoker)delegate
                    {
                        ComboBoxHelper.updateComboBox(Constants.documentsExtension, ref docsComboBox);
                    });

                    mp4ComboBox.Invoke((MethodInvoker)delegate
                    {
                        ComboBoxHelper.updateComboBox(Constants.mp4Extension, ref mp4ComboBox);
                    });
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void observeDiskOnKeyConnectionStatus()
        {
            while (true)
            {
                try
                {
                    diskOnKeyStatusLabel.Invoke((MethodInvoker)delegate
                    {
                        if (DriveInfo.GetDrives().Length > 1)
                        {
                            openDiskOnKeyButton.Enabled = true;
                            diskOnKeyStatusLabel.Text = "מחובר";
                            diskOnKeyStatusLabel.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                        {
                            openDiskOnKeyButton.Enabled = false;
                            diskOnKeyStatusLabel.Text = "לא מחובר";
                            diskOnKeyStatusLabel.ForeColor = System.Drawing.Color.Red;

                        }
                    });
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
