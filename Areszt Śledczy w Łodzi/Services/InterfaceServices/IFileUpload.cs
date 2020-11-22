using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry fileListEntry, string sFolder);
        void SendToServer();
        
    }
}
