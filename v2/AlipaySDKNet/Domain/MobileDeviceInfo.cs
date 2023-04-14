using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MobileDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MobileDeviceInfo : AopObject
    {
        /// <summary>
        /// 设备IMEI信息
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 设备品牌
        /// </summary>
        [XmlElement("mobile_brand")]
        public string MobileBrand { get; set; }

        /// <summary>
        /// 手机型号
        /// </summary>
        [XmlElement("mobile_type")]
        public string MobileType { get; set; }
    }
}
