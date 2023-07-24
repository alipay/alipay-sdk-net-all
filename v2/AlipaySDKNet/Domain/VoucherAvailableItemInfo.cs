using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherAvailableItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherAvailableItemInfo : AopObject
    {
        /// <summary>
        /// 内部商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 外部商品信息
        /// </summary>
        [XmlArray("out_item_info")]
        [XmlArrayItem("voucher_available_out_item_info")]
        public List<VoucherAvailableOutItemInfo> OutItemInfo { get; set; }
    }
}
