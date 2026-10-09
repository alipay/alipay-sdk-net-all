using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDishstatusModifyModel : AopObject
    {
        /// <summary>
        /// 需要改售卖状态的菜品id集合
        /// </summary>
        [XmlArray("dish_ids")]
        [XmlArrayItem("string")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// open:起售；stop:停售
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
