using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppTaskElectricityCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppTaskElectricityCancelModel : AopObject
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 电科院任务id
        /// </summary>
        [XmlElement("out_task_id")]
        public string OutTaskId { get; set; }
    }
}
