using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonGroupendorseSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonGroupendorseSubmitModel : AopObject
    {
        /// <summary>
        /// 子批单的实付保费;单位:分
        /// </summary>
        [XmlElement("endorse_fee")]
        public long EndorseFee { get; set; }

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
        /// 主批单号
        /// </summary>
        [XmlElement("summary_endorse_order_no")]
        public string SummaryEndorseOrderNo { get; set; }

        /// <summary>
        /// 总保费;单位:分
        /// </summary>
        [XmlElement("summary_premium")]
        public long SummaryPremium { get; set; }
    }
}
