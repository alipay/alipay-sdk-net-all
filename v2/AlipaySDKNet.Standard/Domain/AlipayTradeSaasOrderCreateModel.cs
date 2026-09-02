using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSaasOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSaasOrderCreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("additional_options")]
        [XmlArrayItem("string")]
        public List<string> AdditionalOptions { get; set; }

        /// <summary>
        /// 商户业务参数。用于透传业务扩展信息。
        /// </summary>
        [XmlElement("business_params")]
        public SaasBusinessParams BusinessParams { get; set; }

        /// <summary>
        /// 买家信息。pay_channels显式单选BANK_TRANSFER时条件必填。
        /// </summary>
        [XmlElement("buyer_info")]
        public SaasBuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// 收单扩展参数。具体字段按SaasExtendParams结构传入。
        /// </summary>
        [XmlElement("extend_params")]
        public SaasExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 商品明细列表。用于描述本次收款关联的商品或服务明细。
        /// </summary>
        [XmlElement("goods_detail")]
        public SaasGoodsDetail GoodsDetail { get; set; }

        /// <summary>
        /// 商户订单备注，用于账单展示。
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户订单号。由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户回传参数。后续查询和异步通知会原样返回。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 商户可接受的支付渠道，多个渠道使用英文逗号分隔。不传表示不限定渠道。当前支持ALIPAY、BANK_TRANSFER。显式单选BANK_TRANSFER时同步创建银行转账订单。
        /// </summary>
        [XmlElement("pay_channels")]
        public string PayChannels { get; set; }

        /// <summary>
        /// 优惠参数，必须是仅包含字符串值的JSON对象字符串。
        /// </summary>
        [XmlElement("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 查询返回字段控制，数组JSON字符串格式。当前支持fund_bill_list。
        /// </summary>
        [XmlElement("query_options")]
        public string QueryOptions { get; set; }

        /// <summary>
        /// 商户指定的支付成功后回跳地址。传入时必须是包含主机名的完整HTTP或HTTPS地址。
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 安全扩展参数。用于辅助评估交易安全水位，动态调整额度管控策略。
        /// </summary>
        [XmlElement("security_params")]
        public string SecurityParams { get; set; }

        /// <summary>
        /// 订单标题。用于展示给买家和交易记录识别。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单绝对超时时间，格式为yyyy-MM-dd HH:mm:ss。与timeout_express都传时优先使用本字段。
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 订单相对超时时间。支持m、h、d单位，例如15m表示15分钟，2h表示2小时，1d表示1天。与time_expire都不传时系统使用默认超时时间。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后2位，金额必须大于0。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
