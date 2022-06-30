using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MrchCrmUserTagInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MrchCrmUserTagInfo : AopObject
    {
        /// <summary>
        /// 标签code <br> 需保证同一商户下tag_code唯一
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
