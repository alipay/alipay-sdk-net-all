using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNopenModuleUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNopenModuleUnbindModel : AopObject
    {
        /// <summary>
        /// 上位机 itemId 必传
        /// </summary>
        [XmlElement("device_item_id")]
        public string DeviceItemId { get; set; }

        /// <summary>
        /// 绑定的上位机sn 必传
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 模组 item_Id必传
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 模组 mcu_id必传
        /// </summary>
        [XmlElement("mcu_id")]
        public string McuId { get; set; }

        /// <summary>
        /// 模组有 se_uuid 必传
        /// </summary>
        [XmlElement("se_uuid")]
        public string SeUuid { get; set; }

        /// <summary>
        /// 模组有 sn 必传，如碰有源线圈
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 模组供应商 Id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 模组链接模板
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
