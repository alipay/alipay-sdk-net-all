using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeAppPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAppPayModel : AopObject
    {
        /// <summary>
        /// 签约参数。如果希望在sdk中支付并签约，需要在这里传入签约信息。 周期扣款场景 product_code 为 CYCLE_PAY_AUTH 时必填。
        /// </summary>
        [XmlElement("agreement_sign_params")]
        public SignParams AgreementSignParams { get; set; }

        /// <summary>
        /// 订单附加信息。 如果请求时传递了该参数，将在异步通知、对账单中原样返回，同时会在商户和用户的pc账单详情中作为交易描述展示
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割 注，与enable_pay_channels互斥 <a href="https://docs.open.alipay.com/common/wifww7">渠道列表</a>
        /// </summary>
        [XmlElement("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 指定支付渠道，多个渠道以逗号分割。用户只能使用此处指定渠道进行支付。 与disable_pay_channels互斥，支持传入的值：<a target="_blank" href="https://docs.open.alipay.com/common/wifww7">渠道列表</a>。 注意：如果传入了指定支付渠道，则用户只能用指定内的渠道支付，包括营销渠道也要指定才能使用。若所有指定渠道用户都不可使用，将导致用户无法支付，慎用。
        /// </summary>
        [XmlElement("enable_pay_channels")]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// 外部指定买家
        /// </summary>
        [XmlElement("ext_user_info")]
        public ExtUserInfo ExtUserInfo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式，其它说明详见商品明细说明
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商品主类型，取值如下： 0：虚拟类商品； 1：实物类商品。
        /// </summary>
        [XmlElement("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 开票信息
        /// </summary>
        [XmlElement("invoice_info")]
        public InvoiceInfo InvoiceInfo { get; set; }

        /// <summary>
        /// 商户的原始订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数。 如果请求时传递了该参数，支付宝会在异步通知时将该参数原样返回。 本参数必须进行UrlEncode之后才可以发送给支付宝。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 产品码。 商家和支付宝签约的产品码。 枚举值（点击查看签约情况）： <a target="_blank" href="https://opensupport.alipay.com/support/codelab/detail/694/695">QUICK_MSECURITY_PAY</a>：无线快捷支付产品； <a target="_blank" href="https://opensupport.alipay.com/support/codelab/detail/807/1419">CYCLE_PAY_AUTH</a>：周期扣款产品。 默认值为QUICK_MSECURITY_PAY。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠参数  注：仅与支付宝协商后可用
        /// </summary>
        [XmlElement("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 通知参数选项。 商户通过传递该参数来定制需要异步通知的额外字段，数组格式。包括但不限于：["hyb_amount","enterprise_pay_info"]
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 描述分账信息，json格式，详见分账参数说明
        /// </summary>
        [XmlElement("royalty_info")]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致； 如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 结算信息。 json格式，详见结算参数说明。 直付通模式下必传。
        /// </summary>
        [XmlElement("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 指定单通道，仅支持传入一个渠道。 注意： 目前仅支持传入 pcredit，若由于用户原因指定渠道不可用（不能支付），允许用户选择其他渠道支付。 该参数不可与花呗分期参数同时传入。
        /// </summary>
        [XmlElement("specified_channel")]
        public string SpecifiedChannel { get; set; }

        /// <summary>
        /// 商户门店编号。 指商户创建门店时输入的门店编号。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 二级商户信息。 直付通模式和机构间连模式下必传，其它场景下不需要传入。
        /// </summary>
        [XmlElement("sub_merchant")]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单绝对超时时间。 格式为yyyy-MM-dd HH:mm:ss。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 建议使用time_expire字段。  订单相对超时时间。从买家确认支付时间开始计算。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：5m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 默认值为15d。  注： 1. 无线支付场景最小值为5m，低于5m支付超时时间按5m计算。 2. time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
