using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampusPointQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 校区名称模糊搜索关键字
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 纬度 Latitude , 相当于 垂直 y 轴 的坐标 , 纬度的取值范围 -90 度 ~ + 90 度 ;
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度 Longitude , 本初子午线 位置 为 0 度经线 , 相当于水平 x 轴 的坐标 , 经度的取值范围 -180 度 ~ +180 度 ;
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}
