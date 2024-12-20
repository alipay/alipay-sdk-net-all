using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserFlexiblestaffingRiskconsultApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFlexiblestaffingRiskconsultApplyModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 咨询主体信息
        /// </summary>
        [XmlElement("consult_party")]
        public Pariticipant ConsultParty { get; set; }

        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("enterprise_info")]
        public EnterpriseInformation EnterpriseInfo { get; set; }

        /// <summary>
        /// 咨询申请的外部单号，幂等参数，必传
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 岗位
        /// </summary>
        [XmlElement("position")]
        public string Position { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 风险场景，CONSULT_BY_RISK_SCENE场景时，必填 User Account Risk：账户安全咨询 Enterprise Access Risk：社保风险咨询 Enterprise Manager Risk：董监高风险咨询 Account Limit Risk：限权风险咨询
        /// </summary>
        [XmlElement("risk_scene")]
        public string RiskScene { get; set; }
    }
}
