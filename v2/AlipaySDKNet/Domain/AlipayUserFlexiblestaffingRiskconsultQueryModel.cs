using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserFlexiblestaffingRiskconsultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFlexiblestaffingRiskconsultQueryModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 咨询参与方信息
        /// </summary>
        [XmlElement("consult_party")]
        public PariticipantDTO ConsultParty { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 咨询或者转账的外部单号，新逻辑幂等，外部单号必传
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
