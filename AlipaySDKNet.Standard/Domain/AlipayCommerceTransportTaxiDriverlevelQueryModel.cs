using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverlevelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTaxiDriverlevelQueryModel : AopObject
    {
        /// <summary>
        /// 固定值“JUDI”
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [XmlElement("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        [XmlElement("driver_phone")]
        public string DriverPhone { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }
    }
}
