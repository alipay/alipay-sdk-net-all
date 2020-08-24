using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceAddressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceAddressQueryModel : AopObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }
    }
}
