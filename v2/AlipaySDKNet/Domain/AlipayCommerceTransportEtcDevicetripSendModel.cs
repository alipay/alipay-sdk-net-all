using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcDevicetripSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcDevicetripSendModel : AopObject
    {
        /// <summary>
        /// ETC设备卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// ETC设备号
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 实时行程记录
        /// </summary>
        [XmlElement("trip_ino")]
        public EtcDeviceTripInfo TripIno { get; set; }
    }
}
