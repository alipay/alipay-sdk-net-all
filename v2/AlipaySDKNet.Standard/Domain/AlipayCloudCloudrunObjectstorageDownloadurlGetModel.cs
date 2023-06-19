using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageDownloadurlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstorageDownloadurlGetModel : AopObject
    {
        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 欲获取的文件列表
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("download_url_request")]
        public List<DownloadUrlRequest> FileList { get; set; }
    }
}
