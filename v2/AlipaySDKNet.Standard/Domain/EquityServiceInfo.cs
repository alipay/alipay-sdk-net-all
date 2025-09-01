using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EquityServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EquityServiceInfo : AopObject
    {
        /// <summary>
        /// 权益服务代码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 权益服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
