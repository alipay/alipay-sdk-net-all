using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWithholdrepayorderWithholdplanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWithholdrepayorderWithholdplanModifyModel : AopObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 外部商户协议号
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务幂等号，用于做幂等使用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 行业代扣计划
        /// </summary>
        [XmlArray("repay_plan")]
        [XmlArrayItem("industry_withhold_plan_d_t_o")]
        public List<IndustryWithholdPlanDTO> RepayPlan { get; set; }

        /// <summary>
        /// 签约的场景码
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 业务单类型的履约节点，如激活，注意激活仅可进行一次
        /// </summary>
        [XmlElement("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
