﻿using System.Web.Mvc;
using Serenity.Web;
using EntityType = System.String;

namespace Serenity.Services
{
    public class AuditLogController : Controller
    {
        /*[AcceptVerbs("GET", "POST")]
        [JsonFilter]
        public Result<ListResponse<MyRow>> ListAuditLogListRequest request)
        {
            return this.Respond(() => AuditLogService.List(request));
        }*/

        /*[Authorize]
        public FileResult Download(string fileName, string downloadName)
        {
            UploadHelper.CheckFileNameSecurity(fileName);
            fileName = UploadHelper.UploadFilePath("history", fileName);
            var result = new FilePathResult(fileName, "application/octet-stream");
            result.FileDownloadName = downloadName;
            return result;
        }*/
    }
}