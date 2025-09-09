using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantJujibaovoucherVerifyResponse.
    /// </summary>
    public class AlipayMerchantJujibaovoucherVerifyResponse : AopResponse
    {
        /// <summary>
        /// 移动核销结果出参
        /// </summary>
        [XmlElement("contract_root")]
        public ChinaMobileOutContractRoot ContractRoot { get; set; }
    }
}
