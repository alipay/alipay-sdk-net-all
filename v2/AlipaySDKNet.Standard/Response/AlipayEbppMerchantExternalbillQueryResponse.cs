using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppMerchantExternalbillQueryResponse.
    /// </summary>
    public class AlipayEbppMerchantExternalbillQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("external_bill_list")]
        [XmlArrayItem("external_bill_info_result")]
        public List<ExternalBillInfoResult> ExternalBillList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
