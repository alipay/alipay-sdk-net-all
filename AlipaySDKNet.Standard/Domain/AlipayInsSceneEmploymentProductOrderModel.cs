using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEmploymentProductOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEmploymentProductOrderModel : AopObject
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
        /// 订购产品对应的推荐流水号列表
        /// </summary>
        [XmlArray("recom_flow_no_list")]
        [XmlArrayItem("string")]
        public List<string> RecomFlowNoList { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
