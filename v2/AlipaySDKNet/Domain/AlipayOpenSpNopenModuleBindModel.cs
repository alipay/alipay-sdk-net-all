using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNopenModuleBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNopenModuleBindModel : AopObject
    {
        /// <summary>
        /// 设备 adid
        /// </summary>
        [XmlElement("device_ad_id")]
        public string DeviceAdId { get; set; }

        /// <summary>
        /// 设备 bizTid
        /// </summary>
        [XmlElement("device_biz_tid")]
        public string DeviceBizTid { get; set; }

        /// <summary>
        /// 上位机设备 itemId
        /// </summary>
        [XmlElement("device_item_id")]
        public string DeviceItemId { get; set; }

        /// <summary>
        /// 上位机设备 SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 模组 itemId
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 模组 SN（与 url 二选一，必须传且仅传一个）
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 供应商 ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 模组 URL（与 sn 二选一，必须传且仅传一个）
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
