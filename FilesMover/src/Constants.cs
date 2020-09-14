using System;
using System.IO;

namespace FilesMover
{
    class Constants
    {
        private Constants() {}

        public static string DOCUMENTS_FOLDER = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName + "\\Documents";
        public static string DOWNLOADS_FOLDER = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName + "\\Downloads";
  

        public const int numberOfFilesToShowInComboBox = 10;
        public const string presentationsExtension = "pptx";
        public const string documentsExtension = "docx";
        public const string pdfExtension = "pdf";
        public const string mp4Extension = "mp4";
    }
}
