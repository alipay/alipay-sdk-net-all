using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBuyersignCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpayBuyersignCreateResponse : AopResponse
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 签约失败原因，签约失败时返回
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// ipId
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// ipRoleId
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 是否签约成功：true/false
        /// </summary>
        [XmlElement("sign_result")]
        public bool SignResult { get; set; }

        /// <summary>
        /// 网商日志跟踪ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
