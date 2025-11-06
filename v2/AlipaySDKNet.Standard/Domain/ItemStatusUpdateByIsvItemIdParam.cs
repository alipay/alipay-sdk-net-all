using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemStatusUpdateByIsvItemIdParam Data Structure.
    /// </summary>
    [Serializable]
    public class ItemStatusUpdateByIsvItemIdParam : AopObject
    {
        /// <summary>
        /// 外部疫苗ID用于定位商品信息
        /// </summary>
        [XmlElement("isv_item_id")]
        public string IsvItemId { get; set; }

        /// <summary>
        /// 操作类型, 0上架, -1下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
