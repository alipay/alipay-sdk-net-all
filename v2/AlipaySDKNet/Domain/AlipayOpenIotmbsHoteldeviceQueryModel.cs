using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsHoteldeviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsHoteldeviceQueryModel : AopObject
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }
    }
}
