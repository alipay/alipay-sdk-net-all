using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountApplyRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountApplyRequest : AopObject
    {
        /// <summary>
        /// 在哪个主体下进行子户申请，默认不填时为ZN7
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 来源uid，区分国内DO/海外OS。比如：DO200000200406
        /// </summary>
        [XmlElement("source_uid")]
        public string SourceUid { get; set; }
    }
}
