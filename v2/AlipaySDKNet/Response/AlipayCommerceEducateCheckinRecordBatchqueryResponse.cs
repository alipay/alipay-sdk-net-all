using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateCheckinRecordBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCheckinRecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 签到记录列表
        /// </summary>
        [XmlArray("record_list")]
        [XmlArrayItem("edu_check_in_record")]
        public List<EduCheckInRecord> RecordList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
