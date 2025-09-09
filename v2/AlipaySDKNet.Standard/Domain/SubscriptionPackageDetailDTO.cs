using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubscriptionPackageDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SubscriptionPackageDetailDTO : AopObject
    {
        /// <summary>
        /// 套餐金额
        /// </summary>
        [XmlElement("package_amount")]
        public string PackageAmount { get; set; }

        /// <summary>
        /// 套餐id
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }

        /// <summary>
        /// 套餐类型
        /// </summary>
        [XmlElement("package_type")]
        public string PackageType { get; set; }

        /// <summary>
        /// 套餐单位
        /// </summary>
        [XmlElement("package_unit")]
        public string PackageUnit { get; set; }

        /// <summary>
        /// 套餐值
        /// </summary>
        [XmlElement("package_value")]
        public string PackageValue { get; set; }
    }
}
