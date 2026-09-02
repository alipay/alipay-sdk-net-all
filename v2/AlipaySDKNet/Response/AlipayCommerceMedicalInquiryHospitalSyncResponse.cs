using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryHospitalSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalInquiryHospitalSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步记录id
        /// </summary>
        [XmlElement("original_record_id")]
        public string OriginalRecordId { get; set; }
    }
}
