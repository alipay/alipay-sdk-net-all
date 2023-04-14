using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IotQueryDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IotQueryDeviceInfo : AopObject
    {
        /// <summary>
        /// 设备SN
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
