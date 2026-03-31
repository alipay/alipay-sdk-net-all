using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentDeviceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentDeviceInfo : AopObject
    {
        /// <summary>
        /// 序列号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
