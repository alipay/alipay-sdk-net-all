using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthPaymentNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthPaymentNotifyModel : AopObject
    {
        /// <summary>
        /// 商品资源基础价值
        /// </summary>
        [XmlElement("basic_amount")]
        public string BasicAmount { get; set; }

        /// <summary>
        /// 商品资源权益价值
        /// </summary>
        [XmlElement("benefit_amount")]
        public string BenefitAmount { get; set; }

        /// <summary>
        /// 业务状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 由平台分配，领取、消费的品类类型，有储值方案、商品、权益方案等
        /// </summary>
        [XmlElement("commodity_type")]
        public string CommodityType { get; set; }

        /// <summary>
        /// 外部资源品类的id（长度<128）
        /// </summary>
        [XmlElement("out_commodity_id")]
        public string OutCommodityId { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 由平台分配，区分外部回调来源平台的身份
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }

        /// <summary>
        /// 业务流水号（非必填）
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// uuid，用于身份核验（选填）
        /// </summary>
        [XmlElement("validate_token")]
        public string ValidateToken { get; set; }
    }
}
