using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsLogisticscompanyInstantdeliveryQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsLogisticscompanyInstantdeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 即时配送公司列表
        /// </summary>
        [XmlArray("logistics_companies")]
        [XmlArrayItem("logistics_company_result")]
        public List<LogisticsCompanyResult> LogisticsCompanies { get; set; }
    }
}
