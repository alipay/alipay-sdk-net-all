using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentProcurementDeviceInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentProcurementDeviceInfoVO : AopObject
    {
        /// <summary>
        /// 设备号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
