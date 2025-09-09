using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmCrmCallrecordQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmCrmCallrecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 通话记录列表
        /// </summary>
        [XmlArray("call_record_list")]
        [XmlArrayItem("call_record")]
        public List<CallRecord> CallRecordList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
