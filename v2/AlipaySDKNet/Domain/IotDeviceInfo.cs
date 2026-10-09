using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IotDeviceInfo : AopObject
    {
        /// <summary>
        /// 设备SN，如MB01P16N00318，MB01P16N00426，MB01P16N00719
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
