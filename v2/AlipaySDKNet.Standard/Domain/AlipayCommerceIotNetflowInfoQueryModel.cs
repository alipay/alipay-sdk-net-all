using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotNetflowInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotNetflowInfoQueryModel : AopObject
    {
        /// <summary>
        /// 设备的sn/imei/bizTid等信息
        /// </summary>
        [XmlElement("device_tag")]
        public string DeviceTag { get; set; }
    }
}
