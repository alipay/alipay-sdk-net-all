using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClaimStatusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimStatusInfo : AopObject
    {
        /// <summary>
        /// 理赔金额
        /// </summary>
        [XmlElement("claim_amount")]
        public string ClaimAmount { get; set; }

        /// <summary>
        /// 打款支付宝账户名，案件状态为打款成功时必传
        /// </summary>
        [XmlElement("pay_account_name")]
        public string PayAccountName { get; set; }

        /// <summary>
        /// 打款时间，案件状态为打款成功时必传
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 0--退款后快赔追偿 1--理赔中 2--已理赔 3--打款成功 92--理赔失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
