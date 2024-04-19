using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignApplyResponse.
    /// </summary>
    public class AlipayBossProdAntlescenterDocusignApplyResponse : AopResponse
    {
        /// <summary>
        /// 电子签业务受理流水号
        /// </summary>
        [XmlElement("sign_task_request_id")]
        public string SignTaskRequestId { get; set; }
    }
}
