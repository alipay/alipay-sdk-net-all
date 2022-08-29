using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZMGOBasicConfig Data Structure.
    /// </summary>
    [Serializable]
    public class ZMGOBasicConfig : AopObject
    {
        /// <summary>
        /// 商户在芝麻GO配置的业务身份编码
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商家客服电话
        /// </summary>
        [XmlElement("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// 运营商商户支付宝ID。若非ISV代理模式，也就是商户自运营模式，此属性取值与partner_id一致。
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户LOGO
        /// </summary>
        [XmlElement("merchant_custom_logo")]
        public string MerchantCustomLogo { get; set; }

        /// <summary>
        /// 外部业务单号，供幂等使用，需保证每次请求的值都不同
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户的支付宝ID，即为此商户创建芝麻GO模板
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 芝麻GO模板名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        [XmlElement("template_no")]
        public string TemplateNo { get; set; }
    }
}
