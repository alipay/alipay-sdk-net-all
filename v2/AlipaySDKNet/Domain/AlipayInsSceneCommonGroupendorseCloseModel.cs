using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonGroupendorseCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonGroupendorseCloseModel : AopObject
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
        /// 主批单号
        /// </summary>
        [XmlElement("summary_endorse_order_no")]
        public string SummaryEndorseOrderNo { get; set; }
    }
}
