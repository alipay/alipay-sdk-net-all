using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpProvinceAreaItemList Data Structure.
    /// </summary>
    [Serializable]
    public class IcpProvinceAreaItemList : AopObject
    {
        /// <summary>
        /// 城市列表信息
        /// </summary>
        [XmlArray("city_area_items")]
        [XmlArrayItem("icp_city_area_item_list")]
        public List<IcpCityAreaItemList> CityAreaItems { get; set; }

        /// <summary>
        /// 省份的编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 省份中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
