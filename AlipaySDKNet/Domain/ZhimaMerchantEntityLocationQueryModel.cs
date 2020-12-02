using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantEntityLocationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantEntityLocationQueryModel : AopObject
    {
        /// <summary>
        /// 实体类目
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 半径范围
        /// </summary>
        [XmlElement("radius_range")]
        public string RadiusRange { get; set; }
    }
}
