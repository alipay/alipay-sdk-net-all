using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthContractMerchantUnsignResponse.
    /// </summary>
    public class AlipayFinancialnetAuthContractMerchantUnsignResponse : AopResponse
    {
        /// <summary>
        /// 合约批次号列表
        /// </summary>
        [XmlArray("contract_batch_no_list")]
        [XmlArrayItem("string")]
        public List<string> ContractBatchNoList { get; set; }

        /// <summary>
        /// 合约号列表
        /// </summary>
        [XmlArray("contract_no_list")]
        [XmlArrayItem("string")]
        public List<string> ContractNoList { get; set; }
    }
}
