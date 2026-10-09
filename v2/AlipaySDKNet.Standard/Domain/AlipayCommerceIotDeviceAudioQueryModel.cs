using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceAudioQueryModel : AopObject
    {
        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }
    }
}
