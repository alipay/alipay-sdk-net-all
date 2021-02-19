using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterTradeFileInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class InterTradeFileInfoVO : AopObject
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 关联交易审批单发起来源
        /// </summary>
        [XmlElement("file_source")]
        public string FileSource { get; set; }

        /// <summary>
        /// 文件存储类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
