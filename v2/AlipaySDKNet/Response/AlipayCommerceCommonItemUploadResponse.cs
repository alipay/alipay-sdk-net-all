using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonItemUploadResponse.
    /// </summary>
    public class AlipayCommerceCommonItemUploadResponse : AopResponse
    {
        /// <summary>
        /// 商户侧商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 支付宝侧商品id
        /// </summary>
        [XmlElement("platform_item_id")]
        public string PlatformItemId { get; set; }

        /// <summary>
        /// sku提报结果
        /// </summary>
        [XmlArray("sku_result_list")]
        [XmlArrayItem("industry_item_sku_sync_result_d_t_o")]
        public List<IndustryItemSkuSyncResultDTO> SkuResultList { get; set; }
    }
}
