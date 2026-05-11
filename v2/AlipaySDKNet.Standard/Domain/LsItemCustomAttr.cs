using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LsItemCustomAttr Data Structure.
    /// </summary>
    [Serializable]
    public class LsItemCustomAttr : AopObject
    {
        /// <summary>
        /// 自定义属性列表
        /// </summary>
        [XmlArray("attrs")]
        [XmlArrayItem("ls_item_custom_attr_item")]
        public List<LsItemCustomAttrItem> Attrs { get; set; }

        /// <summary>
        /// 属性分组名，如果属性无需分组名可不传
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
