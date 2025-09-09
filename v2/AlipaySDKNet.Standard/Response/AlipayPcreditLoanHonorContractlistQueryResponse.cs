using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorContractlistQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorContractlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议曝光咨询ID
        /// </summary>
        [XmlElement("agreement_consult_serial_no")]
        public string AgreementConsultSerialNo { get; set; }

        /// <summary>
        /// 合同列表
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("honor_contract_d_t_o")]
        public List<HonorContractDTO> Records { get; set; }

        /// <summary>
        /// 协议记录总数
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }
    }
}
