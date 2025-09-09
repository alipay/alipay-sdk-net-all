using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneServiceAvailableQueryResponse.
    /// </summary>
    public class AlipayInsSceneServiceAvailableQueryResponse : AopResponse
    {
        /// <summary>
        /// true 可用，false 不可用
        /// </summary>
        [XmlElement("available_flag")]
        public bool AvailableFlag { get; set; }

        /// <summary>
        /// 服务合约编号
        /// </summary>
        [XmlElement("ser_contract_no")]
        public string SerContractNo { get; set; }
    }
}
