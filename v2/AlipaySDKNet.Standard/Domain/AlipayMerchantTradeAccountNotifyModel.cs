using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantTradeAccountNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantTradeAccountNotifyModel : AopObject
    {
        /// <summary>
        /// 收银员ID，若收银员需要接收动账通知，需要传该字段。该字段值与商户信息查接口中的收银员ID一致
        /// </summary>
        [XmlElement("cashier_id")]
        public string CashierId { get; set; }

        /// <summary>
        /// 商服小程序ID
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 服务商侧商户号
        /// </summary>
        [XmlElement("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 外部业务号，与收款详情中出参的order_no保持一致，每笔动账确保唯一，否则可能导致消息重复发送
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 组合支付的情况下，列表中为多个值
        /// </summary>
        [XmlArray("payer_bank_type_list")]
        [XmlArrayItem("pay_type")]
        public List<PayType> PayerBankTypeList { get; set; }

        /// <summary>
        /// 付款用户在当前商家的当天消费金额，交易成功金额的总和
        /// </summary>
        [XmlElement("payer_total_amount")]
        public string PayerTotalAmount { get; set; }

        /// <summary>
        /// 付款用户在当前商家的当天消费笔数
        /// </summary>
        [XmlElement("payer_total_count")]
        public long PayerTotalCount { get; set; }

        /// <summary>
        /// 付款用户号
        /// </summary>
        [XmlElement("payer_user_no")]
        public string PayerUserNo { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [XmlElement("payer_user_type")]
        public string PayerUserType { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 本交易是支付宝直连交易还是支付宝间连交易
        /// </summary>
        [XmlElement("sub_trade_channel")]
        public string SubTradeChannel { get; set; }

        /// <summary>
        /// 如果是微信交易 ，为sub_mch_id的值 如果是间连支付宝交易，为smid的值 如果是直连支付宝交易，为交易pid的值
        /// </summary>
        [XmlElement("third_party_merchant_no")]
        public string ThirdPartyMerchantNo { get; set; }

        /// <summary>
        /// 第三方订单号 （支付宝、微信等第三方返回的交易订单号）
        /// </summary>
        [XmlElement("third_party_trade_no")]
        public string ThirdPartyTradeNo { get; set; }

        /// <summary>
        /// 当日的交易成功的金额总和
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 当日收款总笔数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易渠道
        /// </summary>
        [XmlElement("trade_channel")]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 交易成功时间
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
