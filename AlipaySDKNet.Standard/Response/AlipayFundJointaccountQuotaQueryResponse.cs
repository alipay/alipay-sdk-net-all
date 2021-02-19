using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundJointaccountQuotaQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 共同账户额度模型
        /// </summary>
        [XmlArray("account_quota")]
        [XmlArrayItem("joint_account_quota_resp_d_t_o")]
        public List<JointAccountQuotaRespDTO> AccountQuota { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 成员ID（如果查询员工才返回）
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
