using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEmploymentPolicyCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEmploymentPolicyCancelModel : AopObject
    {
        /// <summary>
        /// cainiao
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 企业信息
        /// </summary>
        [XmlElement("merchant")]
        public InsCompany Merchant { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保险合作商信息
        /// </summary>
        [XmlElement("partner_organization")]
        public InsPartnerOrganization PartnerOrganization { get; set; }

        /// <summary>
        /// 保单号，一次最多50个
        /// </summary>
        [XmlArray("policy_no_list")]
        [XmlArrayItem("string")]
        public List<string> PolicyNoList { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
