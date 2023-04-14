using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchBoxServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SearchBoxServiceInfo : AopObject
    {
        /// <summary>
        /// 服务类目编码
        /// </summary>
        [XmlElement("service_category_code")]
        public string ServiceCategoryCode { get; set; }

        /// <summary>
        /// 服务类目名称
        /// </summary>
        [XmlElement("service_category_name")]
        public string ServiceCategoryName { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
