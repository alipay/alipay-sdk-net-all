using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityCopyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectActivityCopyModel : AopObject
    {
        /// <summary>
        /// 转移内容，数组类型。目前可选值(不包含引号)："blue_sea"
        /// </summary>
        [XmlArray("copy_contents")]
        [XmlArrayItem("string")]
        public List<string> CopyContents { get; set; }

        /// <summary>
        /// 活动权益复制源smid
        /// </summary>
        [XmlElement("source_smid")]
        public string SourceSmid { get; set; }

        /// <summary>
        /// 活动权益复制目标smid
        /// </summary>
        [XmlElement("target_smid")]
        public string TargetSmid { get; set; }
    }
}
