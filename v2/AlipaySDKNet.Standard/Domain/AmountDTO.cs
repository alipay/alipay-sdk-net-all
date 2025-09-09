using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AmountDTO : AopObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 金额（cent纬度）
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
