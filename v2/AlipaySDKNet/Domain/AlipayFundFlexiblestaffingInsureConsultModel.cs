using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingInsureConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingInsureConsultModel : AopObject
    {
        /// <summary>
        /// 场景码，固定值
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 保险渠道固定值
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("merchant")]
        public InsureCompany Merchant { get; set; }

        /// <summary>
        /// 合作商信息
        /// </summary>
        [XmlElement("partner_organization")]
        public InsurePartnerOrganization PartnerOrganization { get; set; }

        /// <summary>
        /// 产品码,固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 投保场景，打卡模式固定值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
