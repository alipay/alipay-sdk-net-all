using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpeakerActivityItem Data Structure.
    /// </summary>
    [Serializable]
    public class SpeakerActivityItem : AopObject
    {
        /// <summary>
        /// 设备碰激活时间
        /// </summary>
        [XmlElement("biz_touch_active_time")]
        public string BizTouchActiveTime { get; set; }

        /// <summary>
        /// 设备模式
        /// </summary>
        [XmlElement("coop_mode")]
        public string CoopMode { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 设备绑定时间
        /// </summary>
        [XmlElement("first_bind_time")]
        public string FirstBindTime { get; set; }

        /// <summary>
        /// 商户SMI
        /// </summary>
        [XmlElement("last_bind_merchant_id")]
        public string LastBindMerchantId { get; set; }

        /// <summary>
        /// 设备外部补充ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 线圈tagid
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
