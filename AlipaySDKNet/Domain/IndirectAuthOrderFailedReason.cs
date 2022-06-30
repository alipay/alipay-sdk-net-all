using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectAuthOrderFailedReason Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectAuthOrderFailedReason : AopObject
    {
        /// <summary>
        /// 审核失败字段
        /// </summary>
        [XmlElement("fail_param")]
        public string FailParam { get; set; }

        /// <summary>
        /// 描述申请单审核失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }
    }
}
