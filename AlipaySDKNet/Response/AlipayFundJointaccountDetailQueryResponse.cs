using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountDetailQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 企业设置的共同账户的别名
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 额度模型
        /// </summary>
        [XmlArray("account_quota")]
        [XmlArrayItem("joint_account_quota_resp_d_t_o")]
        public List<JointAccountQuotaRespDTO> AccountQuota { get; set; }

        /// <summary>
        /// 交易授权信息 指定收单商户
        /// </summary>
        [XmlElement("authorized_rule")]
        public AuthorizedRuleDTO AuthorizedRule { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
