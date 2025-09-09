using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorPlanBatchqueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorPlanBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 记录列表。result_code=0时必传
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("honor_repay_plan_d_t_o")]
        public List<HonorRepayPlanDTO> Records { get; set; }

        /// <summary>
        /// 记录总条数。result_code=0时必传
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
