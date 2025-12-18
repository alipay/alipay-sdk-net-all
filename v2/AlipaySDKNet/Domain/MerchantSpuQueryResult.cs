using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSpuQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSpuQueryResult : AopObject
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
        /// null
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("rent_sku_info")]
        public List<RentSkuInfo> Skus { get; set; }

        /// <summary>
        /// 上传结果状态。返回SPU_NOT_EXSIT和 CSPU_NOT_EXSIT不存在时
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
