using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmtaskRecordsummaryQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmtaskRecordsummaryQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("hm_record_summary_item")]
        public List<HmRecordSummaryItem> Data { get; set; }
    }
}
