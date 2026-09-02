using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSfamountconvertQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSfamountconvertQueryModel : AopObject
    {
        /// <summary>
        /// 最小货币单位整数
        /// </summary>
        [XmlElement("amount_minor_units")]
        public long AmountMinorUnits { get; set; }

        /// <summary>
        /// 原币种
        /// </summary>
        [XmlElement("from_currency")]
        public string FromCurrency { get; set; }

        /// <summary>
        /// 目标币种
        /// </summary>
        [XmlElement("to_currency")]
        public string ToCurrency { get; set; }
    }
}
