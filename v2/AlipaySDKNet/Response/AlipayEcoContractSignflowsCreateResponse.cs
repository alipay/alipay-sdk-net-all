using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoContractSignflowsCreateResponse.
    /// </summary>
    public class AlipayEcoContractSignflowsCreateResponse : AopResponse
    {
        /// <summary>
        /// 电子合同流程id（需记录到业务系统中，后续相关服务调用都基于此ID）
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }
    }
}
