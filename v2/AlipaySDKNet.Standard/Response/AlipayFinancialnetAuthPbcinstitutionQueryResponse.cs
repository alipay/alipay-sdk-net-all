using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthPbcinstitutionQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthPbcinstitutionQueryResponse : AopResponse
    {
        /// <summary>
        /// 联行号查询结果
        /// </summary>
        [XmlElement("inst_query_result")]
        public string InstQueryResult { get; set; }
    }
}
