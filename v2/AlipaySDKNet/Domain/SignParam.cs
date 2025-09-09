using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignParam Data Structure.
    /// </summary>
    [Serializable]
    public class SignParam : AopObject
    {
        /// <summary>
        /// 请按当前接入的方式进行填充，且输入值必须为文档中的参数取值范围。
        /// </summary>
        [XmlElement("access_params")]
        public AccessParams AccessParams { get; set; }

        /// <summary>
        /// 是否允许花芝GO降级成原代扣（即销售方案指定的代扣产品），在花芝GO场景下才会使用该值。取值：true-允许降级，false-不允许降级。默认为true。
        /// </summary>
        [XmlElement("allow_huazhi_degrade")]
        public bool AllowHuazhiDegrade { get; set; }

        /// <summary>
        /// 设置签约请求的有效时间，单位为秒。如传入600，商户发起签约请求到用户进入支付宝签约页面的时间差不能超过10分钟。
        /// </summary>
        [XmlElement("effect_time")]
        public string EffectTime { get; set; }

        /// <summary>
        /// 商户签约号，代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。 格式规则：支持大写小写字母和数字，最长32位。 商户系统按需传入，如果同一用户在同一产品码、同一签约场景下，签订了多份代扣协议，那么需要指定并传入该值。
        /// </summary>
        [XmlElement("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，用于在签约页面展示，如果为空，则不展示
        /// </summary>
        [XmlElement("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 周期管控规则参数period_rule_params，在签约周期扣款产品（如CYCLE_PAY_AUTH_P）时必传，在签约其他产品时无需传入。 周期扣款产品，会按照这里传入的参数提示用户，并对发起扣款的时间、金额、次数等做相应限制
        /// </summary>
        [XmlElement("period_rule_params")]
        public PeriodRuleParams PeriodRuleParams { get; set; }

        /// <summary>
        /// 个人签约产品码，商户和支付宝签约时确定。
        /// </summary>
        [XmlElement("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 商家和支付宝签约的产品码。 商家扣款产品传入固定值：GENERAL_WITHHOLDING
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户指定优先渠道扣款参数
        /// </summary>
        [XmlArray("recommend_sort_channel_params")]
        [XmlArrayItem("open_api_specified_channel_params_pojo")]
        public List<OpenApiSpecifiedChannelParamsPojo> RecommendSortChannelParams { get; set; }

        /// <summary>
        /// 签约成功后商户用于接收异步通知的地址。如果不传入，签约与支付的异步通知都会发到外层notify_url参数传入的地址；如果外层也未传入，签约与支付的异步通知都会发到商户appid配置的网关地址。
        /// </summary>
        [XmlElement("sign_notify_url")]
        public string SignNotifyUrl { get; set; }

        /// <summary>
        /// 协议签约场景，商户和支付宝签约时确定，商户可咨询技术支持。
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 此参数用于传递子商户信息，无特殊需求时不用关注。目前商户代扣、海外代扣、淘旅行信用住产品支持传入该参数（在销售方案中“是否允许自定义子商户信息”需要选是）。
        /// </summary>
        [XmlElement("sub_merchant")]
        public SignMerchantParams SubMerchant { get; set; }
    }
}
