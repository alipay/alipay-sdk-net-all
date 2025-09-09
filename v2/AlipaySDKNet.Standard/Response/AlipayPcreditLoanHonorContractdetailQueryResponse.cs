using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorContractdetailQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorContractdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 合同列表
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("honor_contract_d_t_o")]
        public List<HonorContractDTO> Records { get; set; }

        /// <summary>
        /// 记录总条数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
