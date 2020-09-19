using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniItemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniItemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 操作类型，固定为：ITEM_BATCHQUERY
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 平台侧商品id列表，最多20个
        /// </summary>
        [XmlArray("platform_item_id_list")]
        [XmlArrayItem("string")]
        public List<string> PlatformItemIdList { get; set; }
    }
}
