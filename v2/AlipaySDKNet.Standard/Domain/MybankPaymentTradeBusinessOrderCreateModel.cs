using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeBusinessOrderCreateModel : AopObject
    {
        /// <summary>
        /// 金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 买家信息
        /// </summary>
        [XmlElement("buyer_info")]
        public UserInfoDetail BuyerInfo { get; set; }

        /// <summary>
        /// 币种，不传默认CNY(人民币)
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("bank_goods_detail")]
        public List<BankGoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 匹配账号，大额支付来账匹配场景必传
        /// </summary>
        [XmlElement("match_account_no")]
        public string MatchAccountNo { get; set; }

        /// <summary>
        /// 订单扩展字段
        /// </summary>
        [XmlElement("order_extend_params")]
        public OrderExtendParams OrderExtendParams { get; set; }

        /// <summary>
        /// 幂等字段，外部平台的单据号，网商订单与外部平台订单一一对应
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 网商银行签约的产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 和out_biz_no保持一致或者可以不填
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 卖家信息
        /// </summary>
        [XmlElement("seller_info")]
        public UserInfoDetail SellerInfo { get; set; }

        /// <summary>
        /// 订单相对超时时间。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
