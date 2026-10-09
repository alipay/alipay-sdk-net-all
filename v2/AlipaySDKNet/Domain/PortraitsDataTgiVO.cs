using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PortraitsDataTgiVO Data Structure.
    /// </summary>
    [Serializable]
    public class PortraitsDataTgiVO : AopObject
    {
        /// <summary>
        /// 画像分析数据
        /// </summary>
        [XmlArray("portraits")]
        [XmlArrayItem("portrait_data_v_o")]
        public List<PortraitDataVO> Portraits { get; set; }

        /// <summary>
        /// 人群显著标签列表
        /// </summary>
        [XmlElement("top_tgi_tags")]
        public TgiTagVO TopTgiTags { get; set; }
    }
}
