using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossContractManagementIdentifyResponse.
    /// </summary>
    public class AlipayBossContractManagementIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [XmlElement("result_set")]
        public InterTradeConsultOpenApiResult ResultSet { get; set; }
    }
}
