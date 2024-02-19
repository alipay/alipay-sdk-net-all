using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EffectiveDatesDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EffectiveDatesDTO : AopObject
    {
        /// <summary>
        /// 价格日期 yyyyMMdd
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 商品单价，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
