using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoboDiscountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RoboDiscountInfo : AopObject
    {
        /// <summary>
        /// 金额，单位：分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
