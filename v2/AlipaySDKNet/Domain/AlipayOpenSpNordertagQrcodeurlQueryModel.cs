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
        /// 物料编号
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }

        /// <summary>
        /// 碰一下链接，若和物料编号同时传入，以物料编号为准
        /// </summary>
        [XmlElement("nfc_url")]
        public string NfcUrl { get; set; }
    }
}
