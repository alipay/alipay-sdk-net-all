using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNdeviceEventSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportNdeviceEventSyncModel : AopObject
    {
        /// <summary>
        /// 司机签到-driverSign
        /// </summary>
        [XmlElement("biz_event_type")]
        public string BizEventType { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 设备序列号，为一串数字或字母，一般为电子产品的标识码
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
