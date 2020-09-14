using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FilesMover
{
    class FilesUtils
    {
        private FilesUtils() {}

        static public String[] getLatestFilesInFolder(string folder, string extension)
        {
            var directoryInfo = new DirectoryInfo(folder);
            return directoryInfo.GetFiles(string.Format("*.{0}",extension))
                                .Where(p => !p.Name.Contains("$"))
                                .OrderByDescending(p => p.CreationTime)
                                .Take(Constants.numberOfFilesToShowInComboBox)
                                .Select(p => p.Name)
                                .ToArray();
        }

        public static string getFolderByExtension(string extension)
        {
            switch (extension)
            {
                case Constants.mp4Extension:
                    return Constants.DOWNLOADS_FOLDER;
                default:
                    return Constants.DOCUMENTS_FOLDER;
            }
        }

        public static void copyToDiskOnKey(ComboBox comboBox,string folder)
        {
            if (comboBox.Items.Count == 0) return;

            string fileName = (string)comboBox.SelectedItem ;
            DriveInfo diskOnKey = DriveInfo.GetDrives().Where(drive => drive.Name != "C:\\").First();
            string source = folder + "\\" + fileName;
            string dest = diskOnKey.Name + fileName;
            try
            {
                File.Copy(source, dest,true);
                MessageBox.Show("הקובץ הועבר");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Data);
                MessageBox.Show("הקובץ לא הועבר. יש לוודא שיש מספיק מקום");
            }
        }

        public static void openDiskOnKeyInFileExplorer()
        {
            if (DriveInfo.GetDrives().Count() > 1)
            {
                DriveInfo diskOnKey = DriveInfo.GetDrives().Where(drive => drive.Name != "C:\\").First();
                Process.Start(diskOnKey.Name);
            }
        }
    }
}
