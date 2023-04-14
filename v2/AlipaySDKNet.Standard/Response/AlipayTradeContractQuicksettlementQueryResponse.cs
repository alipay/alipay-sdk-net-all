using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeContractQuicksettlementQueryResponse.
    /// </summary>
    public class AlipayTradeContractQuicksettlementQueryResponse : AopResponse
    {
        /// <summary>
        /// 极速收总额度，单位元
        /// </summary>
        [XmlElement("credit_quota")]
        public string CreditQuota { get; set; }

        /// <summary>
        /// 待还款金额，单位元
        /// </summary>
        [XmlElement("left_advance_quota")]
        public string LeftAdvanceQuota { get; set; }

        /// <summary>
        /// 当前剩余额度，单位元
        /// </summary>
        [XmlElement("left_credit_quota")]
        public string LeftCreditQuota { get; set; }

        /// <summary>
        /// 服务状态(true: 已开启，false: 已暂停)
        /// </summary>
        [XmlElement("service_state")]
        public string ServiceState { get; set; }

        /// <summary>
        /// 签约状态（true: 已签约，false: 未签约）
        /// </summary>
        [XmlElement("signed")]
        public string Signed { get; set; }
    }
}
