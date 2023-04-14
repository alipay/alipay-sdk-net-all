using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherFileInfo : AopObject
    {
        /// <summary>
        /// 发票文件下载
        /// </summary>
        [XmlElement("file_download_url")]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }
    }
}
