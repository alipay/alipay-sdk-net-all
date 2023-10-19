using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MonoRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MonoRecordDTO : AopObject
    {
        /// <summary>
        /// 通话录音文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 通话录音文件在OSS的存储地址的临时可用链接
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
