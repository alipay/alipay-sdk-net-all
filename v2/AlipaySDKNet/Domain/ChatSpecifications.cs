using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatSpecifications Data Structure.
    /// </summary>
    [Serializable]
    public class ChatSpecifications : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("choice_tools")]
        [XmlArrayItem("choice_tools")]
        public List<ChoiceTools> ChoiceTools { get; set; }

        /// <summary>
        /// 支持思维链输出
        /// </summary>
        [XmlElement("reasoning")]
        public bool Reasoning { get; set; }
    }
}
