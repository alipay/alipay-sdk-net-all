using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AplusOrderDetailList Data Structure.
    /// </summary>
    [Serializable]
    public class AplusOrderDetailList : AopObject
    {
        /// <summary>
        /// 订单购买的总凭证数量
        /// </summary>
        [XmlElement("certificate_count")]
        public long CertificateCount { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id_list")]
        public string CertificateIdList { get; set; }

        /// <summary>
        /// 每条数据依次为，凭证id、凭证状态、凭证原价、凭证售价
        /// </summary>
        [XmlElement("certificate_status_mapping")]
        public string CertificateStatusMapping { get; set; }

        /// <summary>
        /// 订单创建时间（时间戳秒）
        /// </summary>
        [XmlElement("gmt_create")]
        public long GmtCreate { get; set; }

        /// <summary>
        /// 订单状态最后更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public long GmtModified { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商家优惠金额，单位：元
        /// </summary>
        [XmlElement("merchant_discount")]
        public string MerchantDiscount { get; set; }

        /// <summary>
        /// 商家实收金额，单位：元
        /// </summary>
        [XmlElement("merchant_real_receipt_amount")]
        public string MerchantRealReceiptAmount { get; set; }

        /// <summary>
        /// 平台订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_open_id")]
        public string PartnerOpenId { get; set; }

        /// <summary>
        /// 平台优惠金额，单位：元
        /// </summary>
        [XmlElement("platform_discount")]
        public string PlatformDiscount { get; set; }

        /// <summary>
        /// 用户实付金额，单位：元
        /// </summary>
        [XmlElement("real_pay_amount")]
        public string RealPayAmount { get; set; }

        /// <summary>
        /// 三方优惠金额，单位：元
        /// </summary>
        [XmlElement("third_discount")]
        public string ThirdDiscount { get; set; }

        /// <summary>
        /// 订单总金额，单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
