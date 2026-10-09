using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseSubaccountQueryResponse.
    /// </summary>
    public class AnttechOceanbaseSubaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 财资子户申请结果查询
        /// </summary>
        [XmlElement("sub_account_query_result")]
        public SubAccountQueryResult SubAccountQueryResult { get; set; }
    }
}
