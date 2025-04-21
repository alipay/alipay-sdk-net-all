using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenTrendBatchqueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeopenTrendBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 个股分时信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("obj_trend_d_t_o")]
        public List<ObjTrendDTO> Data { get; set; }
    }
}
