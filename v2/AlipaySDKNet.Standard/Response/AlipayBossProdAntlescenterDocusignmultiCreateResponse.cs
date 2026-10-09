using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignmultiCreateResponse.
    /// </summary>
    public class AlipayBossProdAntlescenterDocusignmultiCreateResponse : AopResponse
    {
        /// <summary>
        /// 签署任务流水号id，唯一流水id
        /// </summary>
        [XmlElement("sign_task_id")]
        public string SignTaskId { get; set; }
    }
}
