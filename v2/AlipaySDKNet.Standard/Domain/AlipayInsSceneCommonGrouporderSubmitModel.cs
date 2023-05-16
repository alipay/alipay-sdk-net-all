using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonGrouporderSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonGrouporderSubmitModel : AopObject
    {
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
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 子单数量
        /// </summary>
        [XmlElement("sub_order_count")]
        public long SubOrderCount { get; set; }

        /// <summary>
        /// 主单号
        /// </summary>
        [XmlElement("summary_order_no")]
        public string SummaryOrderNo { get; set; }

        /// <summary>
        /// 总保费，单位分
        /// </summary>
        [XmlElement("summary_order_premium")]
        public long SummaryOrderPremium { get; set; }
    }
}
