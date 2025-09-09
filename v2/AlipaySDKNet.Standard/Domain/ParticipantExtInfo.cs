using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParticipantExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParticipantExtInfo : AopObject
    {
        /// <summary>
        /// 参与方关联的协议号，部分委托场景需要提供，默认可选。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
