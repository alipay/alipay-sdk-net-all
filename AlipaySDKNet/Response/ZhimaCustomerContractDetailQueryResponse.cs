using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerContractDetailQueryResponse.
    /// </summary>
    public class ZhimaCustomerContractDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 合约详情
        /// </summary>
        [XmlElement("contract_detail")]
        public ApiContractDetail ContractDetail { get; set; }
    }
}
