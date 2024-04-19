using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthPbcnameQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthPbcnameQueryResponse : AopResponse
    {
        /// <summary>
        /// 联行号查询结果
        /// </summary>
        [XmlElement("pbc_query_result")]
        public string PbcQueryResult { get; set; }
    }
}
