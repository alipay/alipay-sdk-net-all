using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NiukeExamCallbackResult Data Structure.
    /// </summary>
    [Serializable]
    public class NiukeExamCallbackResult : AopObject
    {
        /// <summary>
        /// 调用结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
