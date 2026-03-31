using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDeviceDataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDeviceDataSendModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("detail_v_o")]
        public List<DetailVO> Details { get; set; }

        /// <summary>
        /// 设备唯一id
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [XmlElement("device_vendor")]
        public string DeviceVendor { get; set; }

        /// <summary>
        /// 厂商侧的用户id
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("statistics")]
        [XmlArrayItem("statistic_v_o")]
        public List<StatisticVO> Statistics { get; set; }
    }
}
