using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalBenefitPointPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalBenefitPointPayModel : AopObject
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 单品购买数量
        /// </summary>
        [XmlElement("buy_quantity")]
        public long BuyQuantity { get; set; }

        /// <summary>
        /// 虎鲸商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 渠道信息
        /// </summary>
        [XmlElement("kz_info")]
        public string KzInfo { get; set; }

        /// <summary>
        /// 医疗商品ID
        /// </summary>
        [XmlElement("med_benefit_id")]
        public string MedBenefitId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 虎鲸SKUID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
