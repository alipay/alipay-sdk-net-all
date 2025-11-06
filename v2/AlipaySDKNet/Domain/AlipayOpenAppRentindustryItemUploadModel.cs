using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRentindustryItemUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRentindustryItemUploadModel : AopObject
    {
        /// <summary>
        /// 商品SKU映射信息
        /// </summary>
        [XmlArray("item_sku_infos")]
        [XmlArrayItem("merchant_upload_spu_info")]
        public List<MerchantUploadSpuInfo> ItemSkuInfos { get; set; }
    }
}
