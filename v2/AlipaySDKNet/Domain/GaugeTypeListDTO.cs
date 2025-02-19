using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GaugeTypeListDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GaugeTypeListDTO : AopObject
    {
        /// <summary>
        /// 量表图标
        /// </summary>
        [XmlElement("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 当前类型下的具体量表列表
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("gauge_type_info_d_t_o")]
        public List<GaugeTypeInfoDTO> Records { get; set; }

        /// <summary>
        /// 量表分类
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
