using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceClerkquotarecordQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceClerkquotarecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页实际数据条数
        /// </summary>
        [XmlElement("curr_page_size")]
        public long CurrPageSize { get; set; }

        /// <summary>
        /// 变更明细列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("clerk_quota_record_query_open_result")]
        public List<ClerkQuotaRecordQueryOpenResult> DataList { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小，单位：条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量，单位：条
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
