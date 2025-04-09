using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemCateattrQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemCateattrQueryModel : AopObject
    {
        /// <summary>
        /// 类目ID，查询类目信息获取类目ID 
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        [XmlElement("item_type")]
        public string ItemType { get; set; }
    }
}
