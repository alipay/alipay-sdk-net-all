using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecialtyDiseasePackage Data Structure.
    /// </summary>
    [Serializable]
    public class SpecialtyDiseasePackage : AopObject
    {
        /// <summary>
        /// 履约有效天数
        /// </summary>
        [XmlElement("fulfillment_valid_days")]
        public long FulfillmentValidDays { get; set; }

        /// <summary>
        /// 服务包描述
        /// </summary>
        [XmlElement("service_package_desc")]
        public string ServicePackageDesc { get; set; }

        /// <summary>
        /// 服务包Id
        /// </summary>
        [XmlElement("service_package_id")]
        public string ServicePackageId { get; set; }

        /// <summary>
        /// 服务包名称，长度1-200
        /// </summary>
        [XmlElement("service_package_name")]
        public string ServicePackageName { get; set; }

        /// <summary>
        /// 服务包价格(分)
        /// </summary>
        [XmlElement("service_package_price")]
        public long ServicePackagePrice { get; set; }
    }
}
