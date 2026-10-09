using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyTradePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyTradePayModel : AopObject
    {
        /// <summary>
        /// 支付授权码。不同支付场景授权码的具体内容不同 付款码支付：付款码值
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 业务扩展参数,json格式
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式。
        /// </summary>
        [XmlArray("goods_detail")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户的原始订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户操作员编号
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 调用方订单号。 由调用方定义，64个字符以内，仅支持字母、数字、下划线。作为幂等字段，需保证在调用方内部不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数。 如果请求时传递了该参数，运营机构会在异步通知时将该参数原样返回。 本参数必须进行UrlEncode之后才可以发送给运营机构。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 产品码，与运营机构签约的产品码值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 支付场景，不同支付场景识别用户的方式不同。 付款码支付：bar_code
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商户门店编号。 指商户创建门店时输入的门店编号。
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商户机具终端编号
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 订单相对超时时间。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。
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
