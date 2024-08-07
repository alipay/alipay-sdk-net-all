using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMoneycardRecordBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMoneycardRecordBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 金额卡使用记录详情
        /// </summary>
        [XmlElement("content")]
        public MoneyCardUseRecordDetail Content { get; set; }

        /// <summary>
        /// 页码，单位页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小，单位条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数，单位页
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总记录条数，单位条
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
