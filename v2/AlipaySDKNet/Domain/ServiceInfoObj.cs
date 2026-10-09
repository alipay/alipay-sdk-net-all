using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceInfoObj Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceInfoObj : AopObject
    {
        /// <summary>
        /// 服务类目
        /// </summary>
        [XmlElement("service_category")]
        public string ServiceCategory { get; set; }

        /// <summary>
        /// 服务内容描述，服务类型是ORDER_BUY和ORDER_HELP时，表示帮买的东西和帮忙的内容
        /// </summary>
        [XmlElement("service_content")]
        public string ServiceContent { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
