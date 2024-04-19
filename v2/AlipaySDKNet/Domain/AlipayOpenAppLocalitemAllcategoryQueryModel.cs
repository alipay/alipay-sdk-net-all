using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppLocalitemAllcategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppLocalitemAllcategoryQueryModel : AopObject
    {
        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }
    }
}
