using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerBehaviorSyncResponse.
    /// </summary>
    public class ZhimaCustomerBehaviorSyncResponse : AopResponse
    {
        /// <summary>
        /// 行为合约号
        /// </summary>
        [XmlElement("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 行为所触发的合约号
        /// </summary>
        [XmlArray("contract_nos")]
        [XmlArrayItem("string")]
        public List<string> ContractNos { get; set; }
    }
}
