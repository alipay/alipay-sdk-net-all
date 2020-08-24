using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptBizData Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptBizData : AopObject
    {
        /// <summary>
        /// 交易实付金额，单位分
        /// </summary>
        [XmlElement("actual_pay_amount")]
        public long ActualPayAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("actual_pay_time")]
        public string ActualPayTime { get; set; }

        /// <summary>
        /// 机具身份id
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 币种（CNY-人命币）
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 取餐号
        /// </summary>
        [XmlElement("fetch_num")]
        public string FetchNum { get; set; }

        /// <summary>
        /// 电子发票链接
        /// </summary>
        [XmlElement("invoice_entry")]
        public string InvoiceEntry { get; set; }

        /// <summary>
        /// 门店优惠金额，单位分
        /// </summary>
        [XmlElement("merchant_discount_amount")]
        public long MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 商户名字
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 订单原价，单位分
        /// </summary>
        [XmlElement("origin_amount")]
        public long OriginAmount { get; set; }

        /// <summary>
        /// 其他优惠
        /// </summary>
        [XmlArray("other_discount_info")]
        [XmlArrayItem("receipt_discount_info")]
        public List<ReceiptDiscountInfo> OtherDiscountInfo { get; set; }

        /// <summary>
        /// 外部订单编号,小票编号
        /// </summary>
        [XmlElement("out_trade_id")]
        public string OutTradeId { get; set; }

        /// <summary>
        /// 平台（tmall）优惠金额，单位分
        /// </summary>
        [XmlElement("platform_discount_amount")]
        public long PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 门店联系方式
        /// </summary>
        [XmlElement("shop_contract")]
        public string ShopContract { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商户类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("receipt_sku")]
        public List<ReceiptSku> Skus { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 交易来源，barcode-扫码，face-刷脸，other-其他
        /// </summary>
        [XmlElement("trade_source")]
        public string TradeSource { get; set; }
    }
}
