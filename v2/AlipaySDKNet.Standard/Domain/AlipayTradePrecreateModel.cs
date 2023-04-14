using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradePrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePrecreateModel : AopObject
    {
        /// <summary>
        /// 支付宝店铺编号。 指商户创建门店后支付宝生成的门店ID。
        /// </summary>
        [XmlElement("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 间联交易下，由收单机构上送的信息
        /// </summary>
        [XmlElement("bkagent_req_info")]
        public BkAgentReqInfo BkagentReqInfo { get; set; }

        /// <summary>
        /// 订单附加信息。 如果请求时传递了该参数，将在异步通知、对账单中原样返回，同时会在商户和用户的pc账单详情中作为交易描述展示
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [XmlElement("business_params")]
        public BusinessParams BusinessParams { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 码类型，如果请求时传入了share_code，将在响应参数返回吱口令；如果为空，则默认为订单码
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割 注，与enable_pay_channels互斥 <a href="https://docs.open.alipay.com/common/wifww7">渠道列表</a>
        /// </summary>
        [XmlElement("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 可打折金额。 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。
        /// </summary>
        [XmlElement("discountable_amount")]
        public string DiscountableAmount { get; set; }

        /// <summary>
        /// 指定支付渠道。 用户只能使用指定的渠道进行支付，多个渠道以逗号分割。 与disable_pay_channels互斥，支持传入的值：<a target="_blank" href="https://docs.open.alipay.com/common/wifww7">渠道列表</a>。 注：如果传入了指定支付渠道，则用户只能用指定内的渠道支付，包括营销渠道也要指定才能使用。该参数可能导致用户支付受限，慎用。
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
        /// 订单包含的商品列表信息.json格式. 其它说明详见：“商品明细说明”
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商户的原始订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户操作员编号。
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数。 如果请求时传递了该参数，支付宝会在异步通知时将该参数原样返回。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 产品码。 商家和支付宝签约的产品码。 枚举值（点击查看签约情况）： <a target="_blank" href="https://opensupport.alipay.com/support/codelab/detail/486/487">FACE_TO_FACE_PAYMENT</a>：当面付产品； 默认值为FACE_TO_FACE_PAYMENT。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 二维码订单相对超时时间。 该笔订单允许的最晚付款时间，逾期将关闭交易，从生成二维码开始计时。 取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 注：二维码最长有效期是2小时，不管该参数传递的值是多少，超过2小时后二维码都将失效不能再进行扫码支付。
        /// </summary>
        [XmlElement("qr_code_timeout_express")]
        public string QrCodeTimeoutExpress { get; set; }

        /// <summary>
        /// 返回参数选项。 商户通过传递该参数来定制需要额外返回的信息字段，数组格式。包括但不限于：["hyb_amount","enterprise_pay_info"]
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 描述分账信息，json格式。
        /// </summary>
        [XmlElement("royalty_info")]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 收款账号优先级规则：门店绑定的收款账户>请求传入的seller_id>商户签约账号对应的支付宝用户ID； 注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致； 如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 描述结算信息，json格式，详见结算参数说明
        /// </summary>
        [XmlElement("settle_info")]
        public SettleInfo SettleInfo { get; set; }

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
        /// 商户机具终端编号。
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 订单绝对超时时间。 格式为yyyy-MM-dd HH:mm:ss。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 订单相对超时时间。 从预下单请求时间开始计算。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。  当面付场景默认值为3h；   注： 1. 二维码最长有效期是2小时，不管该参数传递的值是多少，超过2小时后二维码都将失效不能再进行扫码支付。 2. time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不可打折金额。 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。
        /// </summary>
        [XmlElement("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }
    }
}
