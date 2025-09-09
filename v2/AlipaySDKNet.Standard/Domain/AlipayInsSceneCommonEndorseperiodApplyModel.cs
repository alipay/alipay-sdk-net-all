using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonEndorseperiodApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonEndorseperiodApplyModel : AopObject
    {
        /// <summary>
        /// 期望的结束时间
        /// </summary>
        [XmlElement("expected_effect_end_time")]
        public string ExpectedEffectEndTime { get; set; }

        /// <summary>
        /// 期望的生效时间
        /// </summary>
        [XmlElement("expected_effect_start_time")]
        public string ExpectedEffectStartTime { get; set; }

        /// <summary>
        /// 幂等单号
        /// </summary>
        [XmlElement("idempotent_no")]
        public string IdempotentNo { get; set; }

        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 预下单id
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }
    }
}
