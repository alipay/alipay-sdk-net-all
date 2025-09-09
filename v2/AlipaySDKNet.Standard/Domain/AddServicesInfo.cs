using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AddServicesInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AddServicesInfo : AopObject
    {
        /// <summary>
        /// 增值服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 增值服务价格 单位元
        /// </summary>
        [XmlElement("service_price")]
        public string ServicePrice { get; set; }
    }
}
