using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdIifaaStatusTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdIifaaStatusTriggerModel : AopObject
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("request_param")]
        public string RequestParam { get; set; }
    }
}
