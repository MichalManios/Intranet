using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Services
{
    public class FileUploadServices : IFileUpload
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private MemoryStream ms;
        private string path;
        public FileUploadServices(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task UploadAsync(IFileListEntry fileListEntry, string sFolder)
        {
            path = @"C:\inetpub\publish\wwwroot\"+sFolder+"\\" + fileListEntry.Name;
            ms = new MemoryStream();
            await fileListEntry.Data.CopyToAsync(ms);
        }

        public void SendToServer()
        {
            using(FileStream file=new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }
        }
    }
}
