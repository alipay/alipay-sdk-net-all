using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XhExpressPostInfo Data Structure.
    /// </summary>
    [Serializable]
    public class XhExpressPostInfo : AopObject
    {
        /// <summary>
        /// 详细的邮寄地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 地区国标码
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 地区国标码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 城市国标码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 省份国标码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
