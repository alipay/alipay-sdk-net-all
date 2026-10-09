using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsTagResult Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsTagResult : AopObject
    {
        /// <summary>
        /// 标签code
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
