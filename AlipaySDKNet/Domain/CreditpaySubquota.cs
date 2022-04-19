using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditpaySubquota Data Structure.
    /// </summary>
    [Serializable]
    public class CreditpaySubquota : AopObject
    {
        /// <summary>
        /// 可用额度,单位分
        /// </summary>
        [XmlElement("available_amt")]
        public string AvailableAmt { get; set; }

        /// <summary>
        /// 信用支付子额度类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 总额度,单位分
        /// </summary>
        [XmlElement("total_amt")]
        public string TotalAmt { get; set; }
    }
}
