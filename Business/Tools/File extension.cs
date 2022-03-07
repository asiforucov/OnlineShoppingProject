using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tools
{
    public static class File_extension
    {
        public static bool CheckFileType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }

        public static bool CheckFileSize(this IFormFile file, int sizekb)
        {
            return file.Length / 1024 <= sizekb;
        }

        public async static Task<string> SaveFileAsync(this IFormFile file, string root, params string[] folder)
        {
            string filename = Guid.NewGuid().ToString() + "_" + file.FileName;
            string resultPath = Path.Combine(root, folder[0], folder[1], filename);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return filename;

        }
    }
}
