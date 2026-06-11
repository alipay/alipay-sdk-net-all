using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementItemInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementItemInfoVO : AopObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_cnt")]
        public string ItemCnt { get; set; }

        /// <summary>
        /// 商户侧商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商户侧商品 skuId
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 货源商品id
        /// </summary>
        [XmlElement("supplier_item_id")]
        public string SupplierItemId { get; set; }

        /// <summary>
        /// 货源商品名称
        /// </summary>
        [XmlElement("supplier_item_name")]
        public string SupplierItemName { get; set; }

        /// <summary>
        /// 货源商品skuId
        /// </summary>
        [XmlElement("supplier_sku_id")]
        public string SupplierSkuId { get; set; }
    }
}
