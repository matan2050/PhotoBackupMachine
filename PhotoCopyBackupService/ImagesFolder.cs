using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoCopyBackupService
{
    public class ImagesFolder
    {
        private List<ImageClass>    images;
        private string              folderPath;

        public ImagesFolder(string _folderPath)
        {
            folderPath = _folderPath;
        }

        public void FillImagesList()
        {
            images = new List<ImageClass>();

            string [] imagesInFolder = Directory.GetFiles(folderPath);

            foreach (string imagePath in imagesInFolder)
            {
                images.Add(new ImageClass(imagePath));   
            }
        }

        public void CopyFolder(string targetBase)
        {
            foreach (ImageClass image in images)
            {
                string sourceBase = image.GetPath();
                string targetPath = Path.Combine(targetBase, image.GetDateFolderConvention());

                if (!Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }
                
                string targetPathWithFilename = Path.Combine(targetPath, image.GetFilename());
                string sourcePathWithFilename = Path.Combine(sourceBase);

                if (File.Exists(targetPathWithFilename))
                {
                    continue;
                }
                else
                {
                    File.Copy(sourcePathWithFilename, targetPathWithFilename);
                }
            }
        }
    }
}
