using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotWifiResultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotWifiResultQueryModel : AopObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }
    }
}
