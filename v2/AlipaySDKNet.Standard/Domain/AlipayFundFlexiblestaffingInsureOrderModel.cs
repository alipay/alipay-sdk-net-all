using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingInsureOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingInsureOrderModel : AopObject
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
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保险合作商类型
        /// </summary>
        [XmlElement("partner_organization")]
        public InsurePartnerOrganization PartnerOrganization { get; set; }

        /// <summary>
        /// 产品码，固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订购产品对应的推荐流水号列表
        /// </summary>
        [XmlArray("recom_flow_no_list")]
        [XmlArrayItem("string")]
        public List<string> RecomFlowNoList { get; set; }

        /// <summary>
        /// 投保场景，打卡模式固定值
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
