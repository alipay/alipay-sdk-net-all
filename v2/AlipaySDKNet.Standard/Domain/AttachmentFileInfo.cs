using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttachmentFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AttachmentFileInfo : AopObject
    {
        /// <summary>
        /// 合同的相关描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 可直接访问并下载文件的http地址
        /// </summary>
        [XmlElement("file_http_url")]
        public string FileHttpUrl { get; set; }

        /// <summary>
        /// 文件的显示名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// oss地址
        /// </summary>
        [XmlElement("oss_key")]
        public string OssKey { get; set; }
    }
}
