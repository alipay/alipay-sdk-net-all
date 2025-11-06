using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExtAttributeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExtAttributeInfo : AopObject
    {
        /// <summary>
        /// 属性code，提前和BD确定字段名称，按需填写，具体值从ntouch平台获取，跟每个子解决方案配置的code 要一致
        /// </summary>
        [XmlElement("attr_code")]
        public string AttrCode { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
