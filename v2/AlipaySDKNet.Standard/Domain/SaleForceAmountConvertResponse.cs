using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceAmountConvertResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceAmountConvertResponse : AopObject
    {
        /// <summary>
        /// 最小货币单位整数
        /// </summary>
        [XmlElement("amount_minor_units")]
        public long AmountMinorUnits { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }
    }
}
