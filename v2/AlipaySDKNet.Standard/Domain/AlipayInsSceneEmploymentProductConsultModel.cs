using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEmploymentProductConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEmploymentProductConsultModel : AopObject
    {
        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("merchant")]
        public InsCompany Merchant { get; set; }

        /// <summary>
        /// 保险合作商信息
        /// </summary>
        [XmlElement("partner_organization")]
        public InsPartnerOrganization PartnerOrganization { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
