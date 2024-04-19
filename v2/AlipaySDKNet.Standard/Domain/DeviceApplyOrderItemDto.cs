using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeviceApplyOrderItemDto Data Structure.
    /// </summary>
    [Serializable]
    public class DeviceApplyOrderItemDto : AopObject
    {
        /// <summary>
        /// 申请数量，和sn数量保持一致
        /// </summary>
        [XmlElement("apply_amount")]
        public long ApplyAmount { get; set; }

        /// <summary>
        /// 订单计费模式 BILL（计费），NON_BILL（非计费）
        /// </summary>
        [XmlElement("billed")]
        public string Billed { get; set; }

        /// <summary>
        /// itemId
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("model_number")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// 销售单价 保留两位小数
        /// </summary>
        [XmlElement("selling_price")]
        public string SellingPrice { get; set; }

        /// <summary>
        /// sn列表
        /// </summary>
        [XmlArray("sn_list")]
        [XmlArrayItem("string")]
        public List<string> SnList { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
