using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsRunrecordBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsRunrecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("run_record_list")]
        [XmlArrayItem("sports_run_record")]
        public List<SportsRunRecord> RunRecordList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
