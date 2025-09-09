using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyRiskdetectContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyRiskdetectContentQueryModel : AopObject
    {
        /// <summary>
        /// deviceId和outDeviceId至少传其一
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备时间查询结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部内容id
        /// </summary>
        [XmlElement("out_content_id")]
        public string OutContentId { get; set; }

        /// <summary>
        /// deviceId和outDeviceId至少传其一
        /// </summary>
        [XmlElement("out_device_id")]
        public string OutDeviceId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 设备时间查询开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
