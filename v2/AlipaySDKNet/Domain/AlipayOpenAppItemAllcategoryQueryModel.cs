using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemAllcategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemAllcategoryQueryModel : AopObject
    {
        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }
    }
}
