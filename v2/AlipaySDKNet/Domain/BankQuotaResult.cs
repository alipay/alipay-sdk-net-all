using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankQuotaResult Data Structure.
    /// </summary>
    [Serializable]
    public class BankQuotaResult : AopObject
    {
        /// <summary>
        /// 月度额度（单位：元）
        /// </summary>
        [XmlElement("limit_amount")]
        public string LimitAmount { get; set; }

        /// <summary>
        /// 额度月份
        /// </summary>
        [XmlElement("quota_month")]
        public string QuotaMonth { get; set; }

        /// <summary>
        /// 剩余额度（单位：元）
        /// </summary>
        [XmlElement("remaining_amount")]
        public string RemainingAmount { get; set; }
    }
}
