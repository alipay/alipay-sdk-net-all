using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossContractGeneralCreateResponse.
    /// </summary>
    public class AlipayBossContractGeneralCreateResponse : AopResponse
    {
        /// <summary>
        /// 发起审批返回结果
        /// </summary>
        [XmlElement("result_set")]
        public InterTradetContractOpenApiStartResult ResultSet { get; set; }
    }
}
