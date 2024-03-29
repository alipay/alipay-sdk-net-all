using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMenuCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMenuCreateModel : AopObject
    {
        /// <summary>
        /// 一级菜单列表。说明： * 如果是文本菜单，最多有4个一级菜单，若开发者在后台打开了"咨询反馈"的开关，则只能有3个一级菜单。 * 如果是 ICON 菜单信息，最多有80个一级菜单(忽略二级菜单)。
        /// </summary>
        [XmlArray("button")]
        [XmlArrayItem("button_object")]
        public List<ButtonObject> Button { get; set; }

        /// <summary>
        /// 菜单类型，不填时默认为 text（文本型菜单）。枚举值如下： * text：文本型菜单。 * icon：表示 icon 型菜单，当传值为"icon"时，菜单节点的icon字段必传。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
