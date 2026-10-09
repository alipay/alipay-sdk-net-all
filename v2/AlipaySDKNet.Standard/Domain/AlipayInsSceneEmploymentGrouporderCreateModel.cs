using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEmploymentGrouporderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEmploymentGrouporderCreateModel : AopObject
    {
        /// <summary>
        /// 指定生效时间，生效时间格式必须为自然日0点。
        /// </summary>
        [XmlElement("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant")]
        public InsCompany Merchant { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 保险合作商信息
        /// </summary>
        [XmlElement("partner_organization")]
        public InsPartnerOrganization PartnerOrganization { get; set; }

        /// <summary>
        /// 保障期限
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 推荐流水号
        /// </summary>
        [XmlElement("recom_flow_no")]
        public string RecomFlowNo { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
