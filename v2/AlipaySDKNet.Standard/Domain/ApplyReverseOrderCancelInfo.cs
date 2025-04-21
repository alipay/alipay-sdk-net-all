using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplyReverseOrderCancelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyReverseOrderCancelInfo : AopObject
    {
        /// <summary>
        /// 逆向配送指令集合
        /// </summary>
        [XmlArray("assign_item_ids")]
        [XmlArrayItem("string")]
        public List<string> AssignItemIds { get; set; }

        /// <summary>
        /// 逆向入库单ARO单号
        /// </summary>
        [XmlElement("reverse_apply_order_id")]
        public string ReverseApplyOrderId { get; set; }
    }
}
