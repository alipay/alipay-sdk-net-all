using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditserviceDetailModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantCreditserviceDetailModifyModel : AopObject
    {
        /// <summary>
        /// 信用服务基础信息配置，为必传字段。此字段为复杂模型，其中服务名称和服务logo为必传属性。
        /// </summary>
        [XmlElement("base_info_config")]
        public BaseInfoConfig BaseInfoConfig { get; set; }

        /// <summary>
        /// 信用服务ID，为必传字段
        /// </summary>
        [XmlElement("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 修改信用服务版本扩展字段，为JSON字符串。
        /// </summary>
        [XmlElement("extra_info")]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 信用服务守护配置，为必传字段。此字段为复杂模型，其中商户服务电话为必传属性
        /// </summary>
        [XmlElement("promise_config")]
        public PromiseConfig PromiseConfig { get; set; }

        /// <summary>
        /// 信用服务风控配置，为必传字段。此字段为复杂模型，其中类目code为必传属性。
        /// </summary>
        [XmlElement("risk_config")]
        public RiskConfig RiskConfig { get; set; }
    }
}
