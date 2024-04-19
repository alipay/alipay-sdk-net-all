using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectAccountNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectAccountNotifyModel : AopObject
    {
        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 间联小程序ID
        /// </summary>
        [XmlElement("mrchind_app_id")]
        public string MrchindAppId { get; set; }

        /// <summary>
        /// 外部唯一流水编号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部商户编号(银行商户号)
        /// </summary>
        [XmlElement("out_merchant_no")]
        public string OutMerchantNo { get; set; }

        /// <summary>
        /// 支付渠道，参考枚举如下： ALIPAY:支付宝 WECHAT_PAY:微信支付 UNION_PAY:银联支付 OTHER 其他付款方式
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 透传支付渠道付款方银行值 如果是微信渠道，传bank_type字段 如果是支付宝渠道，拼装字段fund_channel|bank_code|fund_type，中间用英文竖线|间隔
        /// </summary>
        [XmlElement("payer_bank_type")]
        public string PayerBankType { get; set; }

        /// <summary>
        /// 付款用户在当前商户的当天消费总金额
        /// </summary>
        [XmlElement("payer_total_amount_on_the_merchant")]
        public string PayerTotalAmountOnTheMerchant { get; set; }

        /// <summary>
        /// 付款用户在该商家当天的消费笔数
        /// </summary>
        [XmlElement("payer_total_count_on_the_merchant")]
        public long PayerTotalCountOnTheMerchant { get; set; }

        /// <summary>
        /// 付款方用户编号。 如果微信=openid 如果是支付宝=buyer_user_id
        /// </summary>
        [XmlElement("payer_user_no")]
        public string PayerUserNo { get; set; }

        /// <summary>
        /// 若商家在机构侧存在多个门店，可上报此交易对应机构侧的门店编号
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }

        /// <summary>
        /// 若商家在机构侧存在多个门店，可上报此交易对应机构侧的门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商户smid (支付宝进件商户号)
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 三方机构分配的商户识别码 如果是支付宝=smid 如果是微信 = sub_mch_id
        /// </summary>
        [XmlElement("third_party_merchant_no")]
        public string ThirdPartyMerchantNo { get; set; }

        /// <summary>
        /// 第三方订单号 （支付宝、微信等第三方返回的交易订单号）
        /// </summary>
        [XmlElement("third_party_trade_no")]
        public string ThirdPartyTradeNo { get; set; }

        /// <summary>
        /// 当日收款总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 当日收款总笔数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 交易成功时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
