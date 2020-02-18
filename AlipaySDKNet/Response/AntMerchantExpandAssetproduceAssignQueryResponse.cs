using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetproduceAssignQueryResponse.
    /// </summary>
    public class AntMerchantExpandAssetproduceAssignQueryResponse : AopResponse
    {
        /// <summary>
        /// 生产指令集合, 订单明细ID(assign_item_id)为唯一键值.
        /// </summary>
        [XmlArray("asset_produce_items")]
        [XmlArrayItem("asset_produce_item")]
        public List<AssetProduceItem> AssetProduceItems { get; set; }

        /// <summary>
        /// 当前是否还有生产指令可以拉取; 注意如果该值为false, 也只是提示当前没有更多生产指令了, 不代表后面没有生产指令, 商户需要自己制定策略定时去拉取.
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}
