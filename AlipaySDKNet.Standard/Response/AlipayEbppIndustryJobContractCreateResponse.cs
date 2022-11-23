using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryJobContractCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryJobContractCreateResponse : AopResponse
    {
        /// <summary>
        /// 电子合同签署信息返回结果，如果是自动签署场景下无返回内容，可通过查询接口(alipay.ebpp.industry.job.contract.query) 获取签署内容
        /// </summary>
        [XmlArray("sign_rsp_list")]
        [XmlArrayItem("contract_sign_rsp")]
        public List<ContractSignRsp> SignRspList { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
