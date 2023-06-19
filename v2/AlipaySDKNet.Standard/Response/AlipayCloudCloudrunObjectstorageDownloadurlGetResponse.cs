using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageDownloadurlGetResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageDownloadurlGetResponse : AopResponse
    {
        /// <summary>
        /// 文件下载链接列表
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("download_url_response")]
        public List<DownloadUrlResponse> FileList { get; set; }
    }
}
