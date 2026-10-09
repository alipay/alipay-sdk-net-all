using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdAshieldHardeningtaskprocessGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAshieldHardeningtaskprocessGetModel : AopObject
    {
        /// <summary>
        /// 加固任务id
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
