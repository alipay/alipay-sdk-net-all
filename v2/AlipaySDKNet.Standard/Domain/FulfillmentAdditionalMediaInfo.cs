using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentAdditionalMediaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentAdditionalMediaInfo : AopObject
    {
        /// <summary>
        /// 补充凭证类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 补充凭证数据
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
