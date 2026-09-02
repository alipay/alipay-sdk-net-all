using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryDepartmentSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalInquiryDepartmentSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步记录id
        /// </summary>
        [XmlElement("original_record_id")]
        public string OriginalRecordId { get; set; }
    }
}
