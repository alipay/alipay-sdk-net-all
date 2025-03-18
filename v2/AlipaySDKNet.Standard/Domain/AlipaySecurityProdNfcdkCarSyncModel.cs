using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdNfcdkCarSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdNfcdkCarSyncModel : AopObject
    {
        /// <summary>
        /// 车辆状态数据
        /// </summary>
        [XmlElement("car_info")]
        public string CarInfo { get; set; }

        /// <summary>
        /// 数据同步时间
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// 中控设备唯一标识
        /// </summary>
        [XmlElement("tuid")]
        public string Tuid { get; set; }
    }
}
