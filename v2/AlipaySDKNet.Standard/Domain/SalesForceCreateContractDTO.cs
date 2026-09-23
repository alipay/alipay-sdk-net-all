using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalesForceCreateContractDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SalesForceCreateContractDTO : AopObject
    {
        /// <summary>
        /// SF传入的幂等请求号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 业法合同任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
