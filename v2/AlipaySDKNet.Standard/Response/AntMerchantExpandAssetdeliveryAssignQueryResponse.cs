using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetdeliveryAssignQueryResponse.
    /// </summary>
    public class AntMerchantExpandAssetdeliveryAssignQueryResponse : AopResponse
    {
        /// <summary>
        /// 配送指令集合
        /// </summary>
        [XmlArray("asset_delivery_items")]
        [XmlArrayItem("asset_delivery_item")]
        public List<AssetDeliveryItem> AssetDeliveryItems { get; set; }

        /// <summary>
        /// 当前是否还有配送指令可以拉取; 注意如果该值为false, 也只是提示当前时刻没有更多配送指令了, 不代表后面没有配送指令, 商户需要自己制定策略定时去拉取.
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}
