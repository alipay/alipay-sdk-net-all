using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupBuyVerifyDetailList Data Structure.
    /// </summary>
    [Serializable]
    public class GroupBuyVerifyDetailList : AopObject
    {
        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 券码code
        /// </summary>
        [XmlElement("certificate_code")]
        public string CertificateCode { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 单凭证原价，单位：元
        /// </summary>
        [XmlElement("certificate_original_price")]
        public long CertificateOriginalPrice { get; set; }

        /// <summary>
        /// 单凭证售价，单位：元
        /// </summary>
        [XmlElement("certificate_real_price")]
        public long CertificateRealPrice { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商品id
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
        [XmlElement("merchant_fund_amount")]
        public long MerchantFundAmount { get; set; }

        /// <summary>
        /// 商家实收金额，单位：元
        /// </summary>
        [XmlElement("merchant_real_receipt_amount")]
        public long MerchantRealReceiptAmount { get; set; }

        /// <summary>
        /// 订单总金额，单位：分
        /// </summary>
        [XmlElement("order_amount")]
        public long OrderAmount { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 三方优惠金额，单位：元
        /// </summary>
        [XmlElement("other_fund_amount")]
        public long OtherFundAmount { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户开放ID
        /// </summary>
        [XmlElement("partner_open_id")]
        public string PartnerOpenId { get; set; }

        /// <summary>
        /// 平台优惠金额，单位：元
        /// </summary>
        [XmlElement("platform_fund_amount")]
        public long PlatformFundAmount { get; set; }

        /// <summary>
        /// 支付交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }

        /// <summary>
        /// 平台核销单号
        /// </summary>
        [XmlElement("verify_order_no")]
        public string VerifyOrderNo { get; set; }

        /// <summary>
        /// 核销门店id
        /// </summary>
        [XmlElement("verify_shop_id")]
        public string VerifyShopId { get; set; }
    }
}
