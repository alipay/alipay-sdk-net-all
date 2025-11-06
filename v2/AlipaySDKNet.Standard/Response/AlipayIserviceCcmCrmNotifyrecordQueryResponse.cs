using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCcmCrmNotifyrecordQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmCrmNotifyrecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 通知发送记录
        /// </summary>
        [XmlArray("notify_record_list")]
        [XmlArrayItem("notify_record")]
        public List<NotifyRecord> NotifyRecordList { get; set; }

        /// <summary>
        /// 每页的项目数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
