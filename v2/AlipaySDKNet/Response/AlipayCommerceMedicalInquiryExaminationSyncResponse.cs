using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryExaminationSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalInquiryExaminationSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步记录id
        /// </summary>
        [XmlElement("original_record_id")]
        public string OriginalRecordId { get; set; }
    }
}
