using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerContractAcceptCreateResponse.
    /// </summary>
    public class ZhimaCustomerContractAcceptCreateResponse : AopResponse
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }
    }
}
