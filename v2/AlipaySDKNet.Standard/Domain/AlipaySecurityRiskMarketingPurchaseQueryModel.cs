using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskMarketingPurchaseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskMarketingPurchaseQueryModel : AopObject
    {
        /// <summary>
        /// 银行卡号，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 风险咨询方所属的行业类目
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 用于输入用户的身份证 号码。如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 区分咨询渠道，通过哪个平台/业务接入的咨询服务
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 账户登录IP，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 用于输入用户产生交易时的地理位置信息。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("lbs")]
        public string Lbs { get; set; }

        /// <summary>
        /// 如果风险咨询对象是支付宝商家，则填写pid
        /// </summary>
        [XmlElement("mer_pid")]
        public string MerPid { get; set; }

        /// <summary>
        /// 风险咨询类型：01：普惠版；02：RL邀请；默认传01；
        /// </summary>
        [XmlElement("merchant_scene")]
        public string MerchantScene { get; set; }

        /// <summary>
        /// 用于输入用户注册支付宝的手机号码。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用于代表商户风险类型，请按示例值填写
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }

        /// <summary>
        /// 填写风险咨询中对应的商户或服务商对于蚂蚁的类型
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 用户购买或使用服务时产生的具体金额(单位:元)。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("sales_amount")]
        public string SalesAmount { get; set; }

        /// <summary>
        /// 风险咨询对应的自身业务场景/环节
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 用户匹配服务类型, 请按照示例值填写
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }

        /// <summary>
        /// 用于输入用户支付宝的 2088 账号，如不了解此字段如何获取，可了解下静默授权。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
