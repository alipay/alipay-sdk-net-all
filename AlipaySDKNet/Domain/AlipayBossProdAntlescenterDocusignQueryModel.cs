using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdAntlescenterDocusignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdAntlescenterDocusignQueryModel : AopObject
    {
        /// <summary>
        /// 电子签业务受理流水号
        /// </summary>
        [XmlElement("sign_task_request_id")]
        public string SignTaskRequestId { get; set; }
    }
}
