using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordertagQrcodeurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordertagQrcodeurlQueryModel : AopObject
    {
        /// <summary>
        /// 线圈编号
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }
    }
}
