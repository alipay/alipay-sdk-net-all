using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LocalSettleBillItem Data Structure.
    /// </summary>
    [Serializable]
    public class LocalSettleBillItem : AopObject
    {
        /// <summary>
        /// 支付宝优惠（元）
        /// </summary>
        [XmlElement("alipay_discount_amount")]
        public string AlipayDiscountAmount { get; set; }

        /// <summary>
        /// 商品类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 凭证号
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 核销序列号
        /// </summary>
        [XmlElement("certificate_serial_no")]
        public string CertificateSerialNo { get; set; }

        /// <summary>
        /// 商家订单凭证的核销状态，下钻到次序号维度
        /// </summary>
        [XmlElement("certificate_status")]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// 该笔账单的类型
        /// </summary>
        [XmlElement("direction_type_en")]
        public string DirectionTypeEn { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 平台商品库商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 平台商品库商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商家优惠（元）
        /// </summary>
        [XmlElement("mvirtual_amount")]
        public string MvirtualAmount { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部门店ID
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 外部门店备注名
        /// </summary>
        [XmlElement("out_shop_name")]
        public string OutShopName { get; set; }

        /// <summary>
        /// 支付宝账号绑定手机号、银行卡号,脱敏
        /// </summary>
        [XmlElement("settle_account_loginid_bank")]
        public string SettleAccountLoginidBank { get; set; }

        /// <summary>
        /// 结算账号类型
        /// </summary>
        [XmlElement("settle_account_type")]
        public string SettleAccountType { get; set; }

        /// <summary>
        /// 结算金额（元）
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 结算批次号
        /// </summary>
        [XmlElement("settle_batch_no")]
        public string SettleBatchNo { get; set; }

        /// <summary>
        /// 结算时间
        /// </summary>
        [XmlElement("settle_gmt")]
        public string SettleGmt { get; set; }

        /// <summary>
        /// 核销门店ID
        /// </summary>
        [XmlElement("settle_shop_id")]
        public string SettleShopId { get; set; }

        /// <summary>
        /// 核销门店名称
        /// </summary>
        [XmlElement("settle_shop_name")]
        public string SettleShopName { get; set; }

        /// <summary>
        /// 凭证面额（元）
        /// </summary>
        [XmlElement("total_cash")]
        public string TotalCash { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 订单成交场景
        /// </summary>
        [XmlElement("trade_order_scene_desc")]
        public string TradeOrderSceneDesc { get; set; }

        /// <summary>
        /// 核销外部订单号
        /// </summary>
        [XmlElement("use_order_no")]
        public string UseOrderNo { get; set; }

        /// <summary>
        /// 核销时间
        /// </summary>
        [XmlElement("use_time")]
        public string UseTime { get; set; }

        /// <summary>
        /// 核销交易号
        /// </summary>
        [XmlElement("use_trade_no")]
        public string UseTradeNo { get; set; }
    }
}
