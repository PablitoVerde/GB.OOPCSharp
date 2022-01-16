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

        public string Name { get; set; }
        public string FilePath { get; set; }
        public string Type { get; set; }
        public long Size { get; }
        public bool IsReadOnly { get; set; }
        public bool IsHeaden { get; set; }

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

            FileInfo fileInfo = new FileInfo(path);

            Size = fileInfo.Length;
            IsReadOnly = fileInfo.IsReadOnly;
            IsHeaden = fileInfo.Attributes.HasFlag(FileAttributes.ReadOnly);
        }
    }
}
