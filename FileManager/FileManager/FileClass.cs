using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

//Базовый класс файла. Имя выбрано таким, чтобы избежать путаницы с базовой библиотекой

namespace FileManager
{
    internal class FileClass
    {
        private string name; // Имя файла
        private string filePath; // Путь до файла
        private string type; // Расширение файла
        private long size; // Размер файла
        private bool isReadOnly; // Атрибут "только чтение"
        private bool isHeaden; // Атрибут "скрытый"
        private FileInfo fileInformation;

        public string Name { get; set; }
        public string FilePath { get; set; }
        public string Type { get; set; }
        public long Size { get; }
        public bool IsReadOnly { get; set; }
        public bool IsHeaden { get; set; }
        public FileInfo FileInformation { get { return fileInformation; } private set { fileInformation = value; } }

        public FileClass()
        {

        }

        /// <summary>
        /// Консктруктор получения файла. 
        /// </summary>
        /// <param Путь до файла="filePath"></param>
        public FileClass(string path)
        {
            Name = Path.GetFileName(path);
            FilePath = Path.GetFullPath(path);
            Type = Path.GetExtension(path);

            FileInformation = new FileInfo(path);

            Size = FileInformation.Length;
            IsReadOnly = FileInformation.IsReadOnly;
            IsHeaden = FileInformation.Attributes.HasFlag(FileAttributes.ReadOnly);
        }
    }
}
