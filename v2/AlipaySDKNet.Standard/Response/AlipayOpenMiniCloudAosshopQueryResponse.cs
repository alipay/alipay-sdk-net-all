using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudAosshopQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCloudAosshopQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果总量
        /// </summary>
        [XmlElement("item_total_count")]
        public long ItemTotalCount { get; set; }

        /// <summary>
        /// 搜索的item结果列表
        /// </summary>
        [XmlArray("result")]
        [XmlArrayItem("shop_item")]
        public List<ShopItem> Result { get; set; }

        /// <summary>
        /// 埋点上报序列
        /// </summary>
        [XmlElement("sequence")]
        public string Sequence { get; set; }
    }
}
