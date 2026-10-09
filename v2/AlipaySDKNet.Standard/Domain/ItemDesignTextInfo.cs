using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDesignTextInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDesignTextInfo : AopObject
    {
        /// <summary>
        /// 布局文本信息
        /// </summary>
        [XmlArray("design_text_info_list")]
        [XmlArrayItem("design_text_info")]
        public List<DesignTextInfo> DesignTextInfoList { get; set; }

        /// <summary>
        /// 物品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
