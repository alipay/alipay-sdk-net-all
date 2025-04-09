using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WaybillItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillItemVO : AopObject
    {
        /// <summary>
        /// APP方商品编码，对应商品接口的sku_code｜商品编码
        /// </summary>
        [XmlElement("app_item_code")]
        public string AppItemCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity_item")]
        public long QuantityItem { get; set; }
    }
}
