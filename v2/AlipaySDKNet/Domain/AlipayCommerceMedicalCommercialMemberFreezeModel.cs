using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialMemberFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialMemberFreezeModel : AopObject
    {
        /// <summary>
        /// 需要操作的权益资产列表
        /// </summary>
        [XmlArray("benefit_id_list")]
        [XmlArrayItem("string")]
        public List<string> BenefitIdList { get; set; }

        /// <summary>
        /// 权益订单id，支付宝侧用户对商户某一权益的唯一订单子单id。该订单记录了用户的核销次数与总次数，以及订单状态。
        /// </summary>
        [XmlElement("benefit_order_id")]
        public string BenefitOrderId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部订单号，用作幂等
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部产品id列表
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// MEDICAL_DRUG - 医药商品 MEDICAL_EXAMINATION - 体检商品 MEDICAL_COSMETOLOGY - 医美商品 MEDICAL_MOUTH - 口腔商品
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// ORCAS_SAAS - 虎鲸购药
        /// </summary>
        [XmlElement("source_channel")]
        public string SourceChannel { get; set; }

        /// <summary>
        /// 【会员资格】 F：冻结 P：解冻 S：核销
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
