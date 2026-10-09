using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttachmentFile Data Structure.
    /// </summary>
    [Serializable]
    public class AttachmentFile : AopObject
    {
        /// <summary>
        /// 附件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        [XmlElement("oss_key")]
        public string OssKey { get; set; }
    }
}
