using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryQrcodeCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryQrcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("qr_code_result_list")]
        [XmlArrayItem("ebike_charge_qr_code_result")]
        public List<EbikeChargeQrCodeResult> QrCodeResultList { get; set; }
    }
}
