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
        /// 返回筛选状态的类目
        /// </summary>
        [XmlElement("cat_status")]
        public string CatStatus { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }
    }
}
