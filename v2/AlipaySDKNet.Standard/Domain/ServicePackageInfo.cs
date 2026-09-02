using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServicePackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServicePackageInfo : AopObject
    {
        /// <summary>
        /// 服务包到期时间
        /// </summary>
        [XmlElement("service_package_end_time")]
        public string ServicePackageEndTime { get; set; }

        /// <summary>
        /// 服务包ID
        /// </summary>
        [XmlElement("service_package_id")]
        public string ServicePackageId { get; set; }

        /// <summary>
        /// 服务项ID
        /// </summary>
        [XmlElement("service_package_item_id")]
        public string ServicePackageItemId { get; set; }

        /// <summary>
        /// 服务包项目名称
        /// </summary>
        [XmlElement("service_package_item_name")]
        public string ServicePackageItemName { get; set; }

        /// <summary>
        /// 服务包名称
        /// </summary>
        [XmlElement("service_package_name")]
        public string ServicePackageName { get; set; }

        /// <summary>
        /// 服务包订单ID
        /// </summary>
        [XmlElement("service_package_order_id")]
        public string ServicePackageOrderId { get; set; }

        /// <summary>
        /// 服务子项id N选M
        /// </summary>
        [XmlElement("sub_package_item_id")]
        public string SubPackageItemId { get; set; }
    }
}
