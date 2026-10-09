using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppSmartwearStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppSmartwearStatusQueryModel : AopObject
    {
        /// <summary>
        /// 设备型号
        /// </summary>
        [XmlElement("device_model")]
        public string DeviceModel { get; set; }
    }
}
