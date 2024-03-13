using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditserviceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantCreditserviceModifyModel : AopObject
    {
        /// <summary>
        /// 信用服务基础信息配置，为必传字段。此字段为复杂模型，其中服务名称和服务logo为必传属性。
        /// </summary>
        [XmlElement("base_info_config")]
        public BaseInfoApiConfig BaseInfoConfig { get; set; }

        /// <summary>
        /// 信用服务ID，通过zhima.merchant.creditservice.create(芝麻信用信用服务创建)接口创建信用服务后获取。
        /// </summary>
        [XmlElement("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [XmlElement("ext_info_config")]
        public ExtInfoApiConfig ExtInfoConfig { get; set; }

        /// <summary>
        /// 信用服务守护配置，为必传字段。此字段为复杂模型，其中商户服务电话为必传属性
        /// </summary>
        [XmlElement("promise_config")]
        public PromiseApiConfig PromiseConfig { get; set; }

        /// <summary>
        /// 信用服务风控配置，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [XmlElement("risk_config")]
        public RiskApiConfig RiskConfig { get; set; }
    }
}
