using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatLocation Data Structure.
    /// </summary>
    [Serializable]
    public class ChatLocation : AopObject
    {
        /// <summary>
        /// 地理位置纬度，当用户的query需要位置信息，例如附近点单、查询附近充电桩等场景时候，则该参数必填，单位为度。在其他不涉及位置信息的接口时选填。
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地理位置经度，当用户的query需要位置信息，例如附近点单、查询附近充电桩等场景时候，则该参数必传，单位为度。在其他不涉及位置信息的接口时选填。
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// poi的展示名称，在poi_type不同的情况下具体内容也不一样，例如poi_type为HOME的时候，该值可以为“家”；在poi_type为TARGET的时候，该值可以为“市民广场步行街”。
        /// </summary>
        [XmlElement("poi_name")]
        public string PoiName { get; set; }

        /// <summary>
        /// 地理位置的类型标记，用于标注位置的特性
        /// </summary>
        [XmlElement("poi_type")]
        public string PoiType { get; set; }
    }
}
