using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataPrescriptionSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalIndustrydataPrescriptionSyncResponse : AopResponse
    {
        /// <summary>
        /// 支付宝处方id
        /// </summary>
        [XmlElement("alipay_prescription_id")]
        public string AlipayPrescriptionId { get; set; }
    }
}
