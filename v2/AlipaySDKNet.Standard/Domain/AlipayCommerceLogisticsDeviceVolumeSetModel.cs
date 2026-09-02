using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsDeviceVolumeSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsDeviceVolumeSetModel : AopObject
    {
        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("sn_id")]
        public string SnId { get; set; }

        /// <summary>
        /// 0-6整数。0=静音，6=最大音量
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }
    }
}
