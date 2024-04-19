using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceUnifiedApplyResponse.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceUnifiedApplyResponse : AopResponse
    {
        /// <summary>
        /// 业务消息
        /// </summary>
        [XmlElement("biz_message")]
        public string BizMessage { get; set; }

        /// <summary>
        /// 保司投保单号
        /// </summary>
        [XmlElement("inst_apply_no")]
        public string InstApplyNo { get; set; }

        /// <summary>
        /// 保司保单号
        /// </summary>
        [XmlElement("inst_policy_no")]
        public string InstPolicyNo { get; set; }

        /// <summary>
        /// 保单状态
        /// </summary>
        [XmlElement("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 原币种保费
        /// </summary>
        [XmlElement("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 请求交易流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
