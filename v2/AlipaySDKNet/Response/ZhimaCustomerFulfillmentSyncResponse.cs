using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerFulfillmentSyncResponse.
    /// </summary>
    public class ZhimaCustomerFulfillmentSyncResponse : AopResponse
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlArray("contract_nos")]
        [XmlArrayItem("string")]
        public List<string> ContractNos { get; set; }
    }
}
