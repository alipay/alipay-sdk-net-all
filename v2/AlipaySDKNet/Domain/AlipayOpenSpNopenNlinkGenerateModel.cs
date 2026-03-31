using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNopenNlinkGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNopenNlinkGenerateModel : AopObject
    {
        /// <summary>
        /// 设备device_ad_id
        /// </summary>
        [XmlElement("device_ad_id")]
        public string DeviceAdId { get; set; }

        /// <summary>
        /// 设备tid，有则必传
        /// </summary>
        [XmlElement("device_biz_tid")]
        public string DeviceBizTid { get; set; }

        /// <summary>
        /// 设备item_Id
        /// </summary>
        [XmlElement("device_item_id")]
        public string DeviceItemId { get; set; }

        /// <summary>
        /// 设备SN，该字段必传，特殊场景和业务沟通，避免获取链接失败
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 模组item_id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 模组的mcu_id
        /// </summary>
        [XmlElement("mcu_id")]
        public string McuId { get; set; }

        /// <summary>
        /// 模组链接模版
        /// </summary>
        [XmlElement("n_link_template_code")]
        public string NLinkTemplateCode { get; set; }

        /// <summary>
        /// 模组的se_uuid
        /// </summary>
        [XmlElement("se_uuid")]
        public string SeUuid { get; set; }

        /// <summary>
        /// 模组SN
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 模组的供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
