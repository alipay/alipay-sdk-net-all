using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleItemDTO : AopObject
    {
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

        /// <summary>
        /// 记录当前商品的最新快照，用于排查商品的历史变更数据
        /// </summary>
        [XmlElement("snapshot_id")]
        public string SnapshotId { get; set; }
    }
}
