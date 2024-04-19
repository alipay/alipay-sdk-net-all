using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenInstantdeliveryLogisticsBatchqueryResponse.
    /// </summary>
    public class AlipayOpenInstantdeliveryLogisticsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 支持的即时配送公司列表
        /// </summary>
        [XmlArray("logistics_companys")]
        [XmlArrayItem("logistics_company_d_t_o")]
        public List<LogisticsCompanyDTO> LogisticsCompanys { get; set; }
    }
}
