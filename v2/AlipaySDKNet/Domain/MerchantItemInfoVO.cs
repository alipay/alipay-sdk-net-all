using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantItemInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantItemInfoVO : AopObject
    {
        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧sku信息。
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("merchant_sku_info_v_o")]
        public List<MerchantSkuInfoVO> Skus { get; set; }
    }
}
