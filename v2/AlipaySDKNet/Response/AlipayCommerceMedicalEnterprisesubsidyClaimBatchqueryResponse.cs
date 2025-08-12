using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEnterprisesubsidyClaimBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalEnterprisesubsidyClaimBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 报销数据
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("enterprice_subsidy_data")]
        public List<EnterpriceSubsidyData> Data { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
