using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeUpdateContractRequest Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeUpdateContractRequest : AopObject
    {
        /// <summary>
        /// 附件url
        /// </summary>
        [XmlElement("negotiation_file")]
        public string NegotiationFile { get; set; }

        /// <summary>
        /// 合同磋商编号
        /// </summary>
        [XmlElement("negotiation_no")]
        public string NegotiationNo { get; set; }
    }
}
