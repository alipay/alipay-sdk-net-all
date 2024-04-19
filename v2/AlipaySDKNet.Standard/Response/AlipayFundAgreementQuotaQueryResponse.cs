using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAgreementQuotaQueryResponse.
    /// </summary>
    public class AlipayFundAgreementQuotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 单个协议的额度查询结果
        /// </summary>
        [XmlArray("quota_query_response_list")]
        [XmlArrayItem("quota_query_response")]
        public List<QuotaQueryResponse> QuotaQueryResponseList { get; set; }
    }
}
