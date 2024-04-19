using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsccmngOpenapiTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsccmngOpenapiTransferModel : AopObject
    {
        /// <summary>
        /// action参数作为内部processor分支标识
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 内部小二登陆热线工作台的坐席id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 应用内部方法执行参数
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }
    }
}
