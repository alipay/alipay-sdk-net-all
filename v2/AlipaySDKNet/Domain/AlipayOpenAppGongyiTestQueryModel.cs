using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppGongyiTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppGongyiTestQueryModel : AopObject
    {
        /// <summary>
        /// sadfsdaf
        /// </summary>
        [XmlElement("asdf")]
        public AdvertItem Asdf { get; set; }

        /// <summary>
        /// count 不是唯一 取值范围（1-10）
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
