using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdCompanyauthQueryResponse.
    /// </summary>
    public class AlipayBossProdCompanyauthQueryResponse : AopResponse
    {
        /// <summary>
        /// 公司列表查询返回结果
        /// </summary>
        [XmlElement("company_list_query_result")]
        public CompanyListQueryResult CompanyListQueryResult { get; set; }
    }
}
