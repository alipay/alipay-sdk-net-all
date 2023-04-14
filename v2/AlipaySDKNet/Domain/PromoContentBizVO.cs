using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoContentBizVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoContentBizVO : AopObject
    {
        /// <summary>
        /// 具体内容信息
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容元数据ID
        /// </summary>
        [XmlElement("meta_id")]
        public string MetaId { get; set; }

        /// <summary>
        /// 内容的具体类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
