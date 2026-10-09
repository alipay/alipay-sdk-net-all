using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParamValidateTest Data Structure.
    /// </summary>
    [Serializable]
    public class ParamValidateTest : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test")]
        public DialogueProcess Test { get; set; }
    }
}
