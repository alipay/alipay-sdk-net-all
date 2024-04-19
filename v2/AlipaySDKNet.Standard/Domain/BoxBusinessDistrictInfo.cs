using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxBusinessDistrictInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BoxBusinessDistrictInfo : AopObject
    {
        /// <summary>
        /// 应用名
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 商圈ID
        /// </summary>
        [XmlElement("business_district_id")]
        public string BusinessDistrictId { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [XmlElement("business_district_name")]
        public string BusinessDistrictName { get; set; }

        /// <summary>
        /// 商圈所属小程序对应的服务编码
        /// </summary>
        [XmlElement("relate_appid")]
        public string RelateAppid { get; set; }

        /// <summary>
        /// 商圈所属小程序对应的服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
