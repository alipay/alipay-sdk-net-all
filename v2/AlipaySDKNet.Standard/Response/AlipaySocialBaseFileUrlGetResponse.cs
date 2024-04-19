using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseFileUrlGetResponse.
    /// </summary>
    public class AlipaySocialBaseFileUrlGetResponse : AopResponse
    {
        /// <summary>
        /// 带文件拓展名的文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 所下载文件fileid 如果需要转码为转码后的fileId
        /// </summary>
        [XmlElement("target_file_id")]
        public string TargetFileId { get; set; }

        /// <summary>
        /// 文件访问url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
