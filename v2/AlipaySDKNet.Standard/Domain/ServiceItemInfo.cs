using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceItemInfo : AopObject
    {
        /// <summary>
        /// 服务项id
        /// </summary>
        [XmlElement("package_service_item_id")]
        public string PackageServiceItemId { get; set; }

        /// <summary>
        /// 服务项名称
        /// </summary>
        [XmlElement("package_service_item_name")]
        public string PackageServiceItemName { get; set; }
    }
}
