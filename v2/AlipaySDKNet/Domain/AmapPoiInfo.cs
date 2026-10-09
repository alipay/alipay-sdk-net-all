using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmapPoiInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AmapPoiInfo : AopObject
    {
        /// <summary>
        /// 区域编码，area_code属于复杂类型poi_info的子属性，由调用者通过其它途径获取到的poi信息列表中直接携带传入
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 纬度信息，单位一般为度，但是不需携带单位信息，后台有定义好的处理逻辑，调用者无需关心
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度信息，单位一般为度，但是不需携带单位信息，后台有定义好的处理逻辑，调用者无需关心
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// POI地址信息
        /// </summary>
        [XmlElement("poi_address")]
        public string PoiAddress { get; set; }

        /// <summary>
        /// POI编码。poi_code是复杂参数poi_info下的一个子属性，当poi_info参数不为空时，该属性为必填项
        /// </summary>
        [XmlElement("poi_code")]
        public string PoiCode { get; set; }

        /// <summary>
        /// POI名称
        /// </summary>
        [XmlElement("poi_name")]
        public string PoiName { get; set; }

        /// <summary>
        /// POI类型编码，type_code属于复杂类型poi_info的子属性，由调用者通过其它途径获取到的poi信息列表中直接携带传入，没有映射的枚举
        /// </summary>
        [XmlElement("type_code")]
        public string TypeCode { get; set; }

        /// <summary>
        /// POI类型名称，由调用者直接携带传入，没有映射的枚举
        /// </summary>
        [XmlElement("type_name")]
        public string TypeName { get; set; }
    }
}
