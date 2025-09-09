using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleItemSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleItemSyncModel : AopObject
    {
        /// <summary>
        /// 回收商进行产品（商品）变更时需要传入唯一的流水号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 产品code，用来描述商品的SPU_ID
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("recycle_sku_d_t_o")]
        public List<RecycleSkuDTO> Skus { get; set; }
    }
}
