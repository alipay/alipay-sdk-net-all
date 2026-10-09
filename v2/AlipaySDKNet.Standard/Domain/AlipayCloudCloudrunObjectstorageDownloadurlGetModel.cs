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
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 使用主key还是副key进行签名。
        /// </summary>
        [XmlElement("auth_key")]
        public string AuthKey { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 欲获取的文件列表,最多支持同时获取20个文件的下载地址
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("download_url_request")]
        public List<DownloadUrlRequest> FileList { get; set; }
    }
}
