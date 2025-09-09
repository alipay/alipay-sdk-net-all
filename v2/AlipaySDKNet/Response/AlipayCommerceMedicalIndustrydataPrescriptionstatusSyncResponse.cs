using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataPrescriptionstatusSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataPrescriptionstatusSyncResponse : AopResponse
    {
        /// <summary>
        /// alipay_prescription_id
        /// </summary>
        [XmlElement("alipay_prescription_id")]
        public string AlipayPrescriptionId { get; set; }
    }
}
