using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayOffOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class PayOffOrderVO : AopObject
    {
        /// <summary>
        /// 金额，单位元，BigDecimal类型
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 币种Code，如USD CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 是否高优先级处理
        /// </summary>
        [XmlElement("high_priority")]
        public bool HighPriority { get; set; }

        /// <summary>
        /// 待解付资金流水号 唯一键
        /// </summary>
        [XmlElement("pay_off_no")]
        public string PayOffNo { get; set; }

        /// <summary>
        /// 待解付登记薄状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
