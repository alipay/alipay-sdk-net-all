using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinLendServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinLendServiceInfo : AopObject
    {
        /// <summary>
        /// 服务类型 ST_PRO：车抵贷pro ST_STD：车抵贷std ST_PLUS：车抵贷plus
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务类型版本
        /// </summary>
        [XmlElement("service_type_version")]
        public string ServiceTypeVersion { get; set; }
    }
}
