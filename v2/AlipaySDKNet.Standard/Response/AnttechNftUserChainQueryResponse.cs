using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftUserChainQueryResponse.
    /// </summary>
    public class AnttechNftUserChainQueryResponse : AopResponse
    {
        /// <summary>
        /// 账户链上地址
        /// </summary>
        [XmlElement("chain_address")]
        public string ChainAddress { get; set; }
    }
}
