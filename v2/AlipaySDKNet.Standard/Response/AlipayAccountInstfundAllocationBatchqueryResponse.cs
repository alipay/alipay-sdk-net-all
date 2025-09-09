using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountInstfundAllocationBatchqueryResponse.
    /// </summary>
    public class AlipayAccountInstfundAllocationBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小，单位条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlArray("result_object")]
        [XmlArrayItem("inst_fund_flow_record_d_t_o")]
        public List<InstFundFlowRecordDTO> ResultObject { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
