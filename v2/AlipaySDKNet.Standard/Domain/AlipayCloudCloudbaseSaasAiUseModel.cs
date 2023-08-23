using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseSaasAiUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseSaasAiUseModel : AopObject
    {
        /// <summary>
        /// 模型服务编码，具体值咨询模型服务提供者
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 模型服务uri，具体值咨询模型服务提供者
        /// </summary>
        [XmlElement("uri")]
        public string Uri { get; set; }
    }
}
