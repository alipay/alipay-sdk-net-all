using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItemDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItemDeleteModel : AopObject
    {
        /// <summary>
        /// 支付宝平台侧商品ID列表，最多20个，所选商品下所有sku均会被删除。 与out_item_id_list二选一必填，如果两个参数都填，优先使用商家侧商品ID。
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 商家侧商品ID列表，最多20个，所选商品下所有sku均会被删除。 与item_id_list二选一必填。
        /// </summary>
        [XmlArray("out_item_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutItemIdList { get; set; }
    }
}
