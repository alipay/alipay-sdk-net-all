using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SolutionConfig Data Structure.
    /// </summary>
    [Serializable]
    public class SolutionConfig : AopObject
    {
        /// <summary>
        /// 是否允许传输参数
        /// </summary>
        [XmlElement("allow_transfer_param")]
        public bool AllowTransferParam { get; set; }
    }
}
