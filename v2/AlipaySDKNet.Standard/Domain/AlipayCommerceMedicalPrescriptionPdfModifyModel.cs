using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPrescriptionPdfModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPrescriptionPdfModifyModel : AopObject
    {
        /// <summary>
        /// 处方id
        /// </summary>
        [XmlElement("prescription_id")]
        public string PrescriptionId { get; set; }

        /// <summary>
        /// 加签后的处方笺PDF的url地址
        /// </summary>
        [XmlElement("signed_prsc_pdf_url")]
        public string SignedPrscPdfUrl { get; set; }

        /// <summary>
        /// 门店code
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
