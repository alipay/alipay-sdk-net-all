using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantContractStatusModifyResponse.
    /// </summary>
    public class ZhimaMerchantContractStatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 承诺消费合约号，唯一定位用户的一笔合约
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }
    }
}
