using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpCityAreaItemList Data Structure.
    /// </summary>
    [Serializable]
    public class IcpCityAreaItemList : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 地区列表信息
        /// </summary>
        [XmlArray("district_area_items")]
        [XmlArrayItem("icp_district_area_item_list")]
        public List<IcpDistrictAreaItemList> DistrictAreaItems { get; set; }

        /// <summary>
        /// 城市中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
