using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellersignCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellersignCreateResponse : AopResponse
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 签约失败时需要，签约失败原因码
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
        /// 扩展参数
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 成功与否：true/false
        /// </summary>
        [XmlElement("sign_result")]
        public bool SignResult { get; set; }

        /// <summary>
        /// trace信息
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
