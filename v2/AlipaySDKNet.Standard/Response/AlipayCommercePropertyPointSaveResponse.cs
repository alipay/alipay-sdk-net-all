using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyPointSaveResponse.
    /// </summary>
    public class AlipayCommercePropertyPointSaveResponse : AopResponse
    {
        /// <summary>
        /// 点位id
        /// </summary>
        [XmlElement("location_point_id")]
        public string LocationPointId { get; set; }

        /// <summary>
        /// 解绑的线圈id
        /// </summary>
        [XmlElement("nfc_card_id")]
        public string NfcCardId { get; set; }
    }
}
