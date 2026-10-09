using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiptSimpleOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiptSimpleOrderDTO : AopObject
    {
        /// <summary>
        /// 支付宝支付方式对应支付金额
        /// </summary>
        [XmlElement("alipay_amount")]
        public long AlipayAmount { get; set; }

        /// <summary>
        /// 支付宝支付方式对应的支付金额;
        /// </summary>
        [XmlElement("alipay_amout")]
        public long AlipayAmout { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 订单原价金额，单位为元;
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种（CNY-人命币）
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 优惠金额。 如果为空，则默认都没有优惠金额; 有优惠信息，必填
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 有订单优惠信息; 如果为空，则默认都没有优惠信息; 有优惠信息时，必填
        /// </summary>
        [XmlArray("discount_info_list")]
        [XmlArrayItem("discount_info_data_d_t_o")]
        public List<DiscountInfoDataDTO> DiscountInfoList { get; set; }

        /// <summary>
        /// 商户开发票链接。
        /// </summary>
        [XmlElement("invoice_entry")]
        public string InvoiceEntry { get; set; }

        /// <summary>
        /// 商户商品信息列表;
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("item_order_info_d_t_o")]
        public List<ItemOrderInfoDTO> ItemOrderList { get; set; }

        /// <summary>
        /// 商家扩展信息
        /// </summary>
        [XmlElement("merchant_extend_info")]
        public ReceiptMerchantExtendInfo MerchantExtendInfo { get; set; }

        /// <summary>
        /// 商户名字
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 订单创建时间; 时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// APPID,商户可自定义需要跳转到小程序（默认进入小程序首页）
        /// </summary>
        [XmlElement("order_link")]
        public string OrderLink { get; set; }

        /// <summary>
        /// 订单修改时间，一般不需要传入。用于订单状态或数据变化较快的顺序控制，order_modified_time较晚的同步会被最终存储，order_modified_time相同的两次同步可能会被幂等处理，FMCG按照行业标准化接入场景必须传入该字段控制乱序; 时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 订单支付时间，当pay_channel为非ALIPAY时，且订单状态已流转到“支付”或支付后时，需要将支付时间传入;支付交易完成时，必填；时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 每次请求必传;所有订单类型枚举: 快消:FMCG; 酒店:HOTEL; 智能售卖:AUTOMAT; 景区:RESORT;高校:HIGHSCHOOL;品牌：FASHION; 商圈综合体:MALL; 充电宝:POWERBANK; 物流:LOGISTICS
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 其它支付金额；如果有除支付宝支付方式以外的所有支付方式金额(包括各类卡，现金等)，必填
        /// </summary>
        [XmlElement("other_pay_amount")]
        public long OtherPayAmount { get; set; }

        /// <summary>
        /// 外部商户订单号;out_biz_no唯一对应一笔订单，相同的订单需传入相同的out_biz_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付金额，需要实际支付的金额。如果不涉及金额可不传入该字段，其他场景必填; 0元订单时，必填;
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付类型:alipay:支付宝，otherpay：其它; 支付宝支付时，必填;  森林能量发放仅支持支付宝支付("alipay")和0元订单("otherpay")
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

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
        /// 门店名称; 拥有门店的场景时，展示; 否则无法展示门店信息
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商户类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号; 支付宝支付时，必填; 特殊情况:  无支付场景时，可不填;
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易号类型:1. TRADE-交易，为空默认为TRADE;2. TRANSFER-转账;3. ENTRUST-受托;
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
