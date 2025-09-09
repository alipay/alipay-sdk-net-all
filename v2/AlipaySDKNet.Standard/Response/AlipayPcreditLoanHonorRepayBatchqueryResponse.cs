using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorRepayBatchqueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorRepayBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 还款记录列表。result_code=0时必填
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("honor_repay_record_d_t_o")]
        public List<HonorRepayRecordDTO> Records { get; set; }

        /// <summary>
        /// 记录总条数。result_code=0时必填
        /// </summary>
        [XmlElement("total_num")]
        public string TotalNum { get; set; }
    }
}
