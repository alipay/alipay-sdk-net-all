using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotPointDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotPointDeleteModel : AopObject
    {
        /// <summary>
        /// 外部点位编号
        /// </summary>
        [XmlElement("out_device_point_id")]
        public string OutDevicePointId { get; set; }
    }
}
