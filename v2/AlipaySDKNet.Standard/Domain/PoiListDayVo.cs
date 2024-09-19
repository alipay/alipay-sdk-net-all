using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoiListDayVo Data Structure.
    /// </summary>
    [Serializable]
    public class PoiListDayVo : AopObject
    {
        /// <summary>
        /// 第几天
        /// </summary>
        [XmlElement("day")]
        public string Day { get; set; }

        /// <summary>
        /// 景点列表
        /// </summary>
        [XmlArray("poi_info_vo_list")]
        [XmlArrayItem("poi_info_vo")]
        public List<PoiInfoVo> PoiInfoVoList { get; set; }
    }
}
