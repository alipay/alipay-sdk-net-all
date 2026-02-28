using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyConfigSolutionConfig Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyConfigSolutionConfig : AopObject
    {
        /// <summary>
        /// 是否允许传输参数
        /// </summary>
        [XmlElement("allow_transfer_param")]
        public bool AllowTransferParam { get; set; }
    }
}
