using System;
using System.Windows.Forms;

namespace FilesMover
{
    class ComboBoxHelper
    {
        private ComboBoxHelper() {}

        static public void initComboBoxWithLatestFiles(ref ComboBox comboBox, string extension)
        {
            string folder = FilesUtils.getFolderByExtension(extension);
            String[] latestFiles = FilesUtils.getLatestFilesInFolder(folder, extension);
            setupCombobox(ref comboBox, latestFiles);
        }

        public static void updateComboBox(string extension, ref ComboBox comboBox)
        {
            if (comboBox.Items.Count == 0) return;

            string folder = FilesUtils.getFolderByExtension(extension);
            string latestFileInComboBox = (string)comboBox.Items[0];
            string[] latestFiles = FilesUtils.getLatestFilesInFolder(folder, extension);
            if (latestFileInComboBox != latestFiles[0])
            {
                setupCombobox(ref comboBox, latestFiles);
            }
        }

        private static void setupCombobox(ref ComboBox comboBox, string[] latestFiles)
        {
            comboBox.Items.Clear();
            foreach (String fileName in latestFiles)
            {
                comboBox.Items.Add(fileName);
            }
            comboBox.SelectedIndex = 0;
        }
    }
}
