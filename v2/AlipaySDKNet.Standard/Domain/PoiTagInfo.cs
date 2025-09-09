using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PoiTagInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PoiTagInfo : AopObject
    {
        /// <summary>
        /// 景点列表
        /// </summary>
        [XmlArray("poi_info_list")]
        [XmlArrayItem("poi_info_vo")]
        public List<PoiInfoVo> PoiInfoList { get; set; }

        /// <summary>
        /// 景点标签名
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
