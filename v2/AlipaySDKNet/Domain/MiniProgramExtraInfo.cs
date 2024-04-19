using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniProgramExtraInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniProgramExtraInfo : AopObject
    {
        /// <summary>
        /// mini_program_id+否+服务商提供待处理的小程序ID
        /// </summary>
        [XmlElement("mini_program_id")]
        public string MiniProgramId { get; set; }
    }
}
