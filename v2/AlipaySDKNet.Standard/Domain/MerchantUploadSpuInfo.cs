using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantUploadSpuInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantUploadSpuInfo : AopObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商家侧商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧商品名
        /// </summary>
        [XmlElement("out_item_name")]
        public string OutItemName { get; set; }

        /// <summary>
        /// sku数组,out_sku_id和销售规格kv对
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("rent_sku_info")]
        public List<RentSkuInfo> Skus { get; set; }
    }
}
