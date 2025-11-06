using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetApplyOrderCancelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetApplyOrderCancelInfo : AopObject
    {
        /// <summary>
        /// AO单号
        /// </summary>
        [XmlElement("apply_order_id")]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 配送指令列表
        /// </summary>
        [XmlArray("assign_item_ids")]
        [XmlArrayItem("string")]
        public List<string> AssignItemIds { get; set; }
    }
}
