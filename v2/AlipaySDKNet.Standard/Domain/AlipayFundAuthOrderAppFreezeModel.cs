using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAuthOrderAppFreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAuthOrderAppFreezeModel : AopObject
    {
        /// <summary>
        /// 需要冻结的金额，单位为：元（人民币），精确到小数点后两位。 取值范围：[0.01,100000000.00]
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务参数，如风控参数outRiskInfo等。
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 无特殊需要请勿传入；商户可用该参数禁用支付渠道。 传入后用户不可使用列表中的渠道进行支付，目前支持两种禁用渠道：信用卡快捷（OPTIMIZED_MOTO）、信用卡卡通（BIGAMOUNT_CREDIT_CARTOON）。与可用支付渠道不能同时传入
        /// </summary>
        [XmlElement("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 无特殊需要请勿传入；商户可用该参数指定支付渠道。 传入后用户仅能使用列表中的渠道进行支付，目前支持三种渠道，余额宝（MONEY_FUND）、花呗（PCREDIT_PAY）以及芝麻信用（CREDITZHIMA）。与禁用支付渠道不可同时传入
        /// </summary>
        [XmlElement("enable_pay_channels")]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// 业务扩展参数，用于特定业务信息的传递，json格式。 1、category，信用类目，信用预授权场景必传，具体类目信息见https://opendocs.alipay.com/open/10719； 2、serviceId，信用服务id，信用预授权场景必传，需要联系芝麻客服获取，https://cshall.alipay.com/enterprise/index.htm?sourceId=pc_zhima（右上角“有问题点我”进入咨询）； 3、creditExtInfo，信用参数，可选，如有需要请与芝麻约定后传入，信用服务说明见https://opendocs.alipay.com/open/11157/qlsxya
        /// </summary>
        [XmlElement("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 无特殊需要请勿传入；买家实名信息。 传入后支付宝会比对买家在支付宝端的实名信息。包含两个可选key： 1.identity_hash，买家姓名拼接身份证号后，使用SHA256摘要方式与UTF8编码后的hash值，返回的十六进制字符串，例如 “张三4566498798498498498498”对应的identity_hash应为“acc2b92ffc5ed9b472faa19748f10045c30434132784f774b00216a56b8841c6” 2.alipay_user_id，买家uid
        /// </summary>
        [XmlElement("identity_params")]
        public string IdentityParams { get; set; }

        /// <summary>
        /// 订单标题。 业务订单的简单描述，如商品名称等
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户授权资金订单号。 商家自定义需保证在商户端不重复。仅支持字母、数字、下划线。
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户本次资金操作的请求流水号，用于标示请求流水的唯一性。 可与out_order_no相同，仅支持字母、数字、下划线。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 预授权订单相对超时时间。从商户客户端请求时间开始计算。 预授权订单允许的最晚授权时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m。 默认为15m。
        /// </summary>
        [XmlElement("pay_timeout")]
        public string PayTimeout { get; set; }

        /// <summary>
        /// 收款账户的支付宝登录号（email或手机号）。 如果传入则会校验该登录号对应的账号是否具备当前商户收款权限，如果商户希望用户能够使用花呗，则用户号(payee_user_id)和登录号(payee_logon_id)两者必须传入其一
        /// </summary>
        [XmlElement("payee_logon_id")]
        public string PayeeLogonId { get; set; }

        /// <summary>
        /// 收款账户的支付宝用户号。 以2088开头的16位纯数字，如果传入则会校验该账号是否具备当前商户收款权限，如果商户希望用户能够使用花呗，则用户号(payee_user_id)和登录号(payee_logon_id)两者必须传入其一
        /// </summary>
        [XmlElement("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 销售产品码。 支付宝预授权产品固定为 PRE_AUTH_ONLINE
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码，用于区分预授权不同业务场景。如：当面预授权通用场景（O2O_AUTH_COMMON_SCENE）、支付宝预授权通用场景（ONLINE_AUTH_COMMON_SCENE）、境外当面预授权通用场景（OVERSEAS_O2O_AUTH_COMMON_SCENE）、境外支付预授权通用场景（OVERSEAS_ONLINE_AUTH_COMMON_SCENE）等
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 商户指定的结算币种。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP
        /// </summary>
        [XmlElement("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 预授权订单相对超时时间。从商户客户端请求时间开始计算。 预授权订单允许的最晚授权时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m。 默认为15m。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP, 人民币：CNY
        /// </summary>
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
