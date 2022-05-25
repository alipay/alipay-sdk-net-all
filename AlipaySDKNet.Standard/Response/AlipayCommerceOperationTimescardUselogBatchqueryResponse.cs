using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationTimescardUselogBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceOperationTimescardUselogBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 次卡使用记录
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("time_card_use_log_record_info")]
        public List<TimeCardUseLogRecordInfo> Datas { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页size
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页总的记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
