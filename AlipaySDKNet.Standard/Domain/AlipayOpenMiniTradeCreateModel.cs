using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTradeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTradeCreateModel : AopObject
    {
        /// <summary>
        /// 间联交易下，由收单机构上送的信息
        /// </summary>
        [XmlElement("bkagent_req_info")]
        public BkAgentReqInfoDTO BkagentReqInfo { get; set; }

        /// <summary>
        /// 如果请求时传递了该参数，将在异步通知、对账单中原样返回，同时会在商户和用户的pc账单详情中作为交易描述展示
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [XmlElement("business_params")]
        public BusinessParamsDTO BusinessParams { get; set; }

        /// <summary>
        /// 088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息; 注：交易的买家与卖家不能相同。
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝登录账号。 buyer_logon_id和buyer_id两者传其一，和buyer_id不能同时为空，建议通过buyer_id来传递买家信息。
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。 如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入
        /// </summary>
        [XmlElement("discountable_amount")]
        public string DiscountableAmount { get; set; }

        /// <summary>
        /// 订单扩展字段
        /// </summary>
        [XmlElement("ext_info")]
        public OrderExtInfoDTO ExtInfo { get; set; }

        /// <summary>
        /// 外部指定买家
        /// </summary>
        [XmlElement("ext_user_info")]
        public ExtUserInfoDTO ExtUserInfo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public ExtendParamsDTO ExtendParams { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("item_order_list")]
        [XmlArrayItem("goods_detail_info_d_t_o")]
        public List<GoodsDetailInfoDTO> ItemOrderList { get; set; }

        /// <summary>
        /// 物流信息
        /// </summary>
        [XmlElement("logistics_info")]
        public LogisticsDetailDTO LogisticsInfo { get; set; }

        /// <summary>
        /// 订单类型,参照订单中心模板列表
        /// </summary>
        [XmlElement("merchant_biz_type")]
        public string MerchantBizType { get; set; }

        /// <summary>
        /// 商家小程序对应的订单详情页路径地址 value。仅需传入小程序页面路径即可。同一笔订单的链接必须与第一次传入的地址相同，且需是小程序内部页面路径，例如：/pages/index/index?orderId=10190608609185
        /// </summary>
        [XmlElement("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 商户操作员编号
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户通过传递该参数来定制需要额外返回的信息字段，数组格式。包括但不限于：["enterprise_pay_info","hyb_amount"]
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 收货人及地址信息
        /// </summary>
        [XmlElement("receiver_address_info")]
        public ReceiverAddressInfoDTO ReceiverAddressInfo { get; set; }

        /// <summary>
        /// 描述分账信息，json格式
        /// </summary>
        [XmlElement("royalty_info")]
        public RoyaltyInfoDTO RoyaltyInfo { get; set; }

        /// <summary>
        /// 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 收款账号优先级规则：门店绑定的收款账户>请求传入的seller_id>商户签约账号对应的支付宝用户ID； 注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致； 如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家支付宝用户唯一标识，与seller_id选其一
        /// </summary>
        [XmlElement("seller_open_id")]
        public string SellerOpenId { get; set; }

        /// <summary>
        /// 结算信息
        /// </summary>
        [XmlElement("settle_info")]
        public SettleInfoDTO SettleInfo { get; set; }

        /// <summary>
        /// 指商户创建门店时输入的门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 二级商户信息。 直付通模式和机构间连模式下必传，其它场景下不需要传入
        /// </summary>
        [XmlElement("sub_merchant")]
        public SubMerchantDTO SubMerchant { get; set; }

        /// <summary>
        /// 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商户机具终端编号
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 格式为yyyy-MM-dd HH:mm:ss。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 从交易创建时间开始计算。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 当面付场景默认值为3h。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。 如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入
        /// </summary>
        [XmlElement("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }
    }
}
