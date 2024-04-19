using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundEnterprisepayRuleQueryResponse.
    /// </summary>
    public class AlipayFundEnterprisepayRuleQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户限制信息，包含商户限制类型以及被限制对象的SMID或者PID
        /// </summary>
        [XmlElement("merchant_limit")]
        public MerchantLimit MerchantLimit { get; set; }

        /// <summary>
        /// 额度列表：包含额度类型和额度上限
        /// </summary>
        [XmlArray("quota_list")]
        [XmlArrayItem("joint_account_quota_d_t_o")]
        public List<JointAccountQuotaDTO> QuotaList { get; set; }
    }
}
