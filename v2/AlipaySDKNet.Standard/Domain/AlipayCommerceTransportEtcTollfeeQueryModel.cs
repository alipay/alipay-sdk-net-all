using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcTollfeeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcTollfeeQueryModel : AopObject
    {
        /// <summary>
        /// 调用方标识为支付宝侧定义分给调用方的，识别调用方标识
        /// </summary>
        [XmlElement("caller_id")]
        public string CallerId { get; set; }

        /// <summary>
        /// 出口收费站纬度
        /// </summary>
        [XmlElement("end_latitude")]
        public string EndLatitude { get; set; }

        /// <summary>
        /// 出口收费站经度
        /// </summary>
        [XmlElement("end_longitude")]
        public string EndLongitude { get; set; }

        /// <summary>
        /// 出口收费站名称
        /// </summary>
        [XmlElement("end_station_name")]
        public string EndStationName { get; set; }

        /// <summary>
        /// 起点收费站纬度
        /// </summary>
        [XmlElement("start_latitude")]
        public string StartLatitude { get; set; }

        /// <summary>
        /// 起点收费站经度
        /// </summary>
        [XmlElement("start_longitude")]
        public string StartLongitude { get; set; }

        /// <summary>
        /// 起点收费站名称
        /// </summary>
        [XmlElement("start_station_name")]
        public string StartStationName { get; set; }
    }
}
