using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Params Data Structure.
    /// </summary>
    [Serializable]
    public class Params : AopObject
    {
        /// <summary>
        /// 开卡时商家 CRM 回调模式，枚举值： ● SPI（SPI极速开卡） ● OPENAPI（OpenAPI开卡） 如不传或输入非法参数，默认值：SPI。
        /// </summary>
        [XmlElement("callback_type")]
        public string CallbackType { get; set; }

        /// <summary>
        /// 透传参数，在开卡 SPI 调用时透传至商家 CRM 服务端。OPENAPI 开卡不支持透传
        /// </summary>
        [XmlElement("out_string")]
        public string OutString { get; set; }

        /// <summary>
        /// 用于配置会员卡模板的开放平台商家应用ID
        /// </summary>
        [XmlElement("provider_application_id")]
        public string ProviderApplicationId { get; set; }

        /// <summary>
        /// 配置会员卡模板对应的商户PID
        /// </summary>
        [XmlElement("provider_id")]
        public string ProviderId { get; set; }

        /// <summary>
        /// 跳转的小程序地址
        /// </summary>
        [XmlElement("regist_alipay_schema")]
        public string RegistAlipaySchema { get; set; }

        /// <summary>
        /// miniProgramRegist：小程序注册 传递了miniProgramRegist时，需要传递 ● registAlipaySchema
        /// </summary>
        [XmlElement("regist_mode")]
        public string RegistMode { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
