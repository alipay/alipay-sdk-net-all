using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GovDocRequest Data Structure.
    /// </summary>
    [Serializable]
    public class GovDocRequest : AopObject
    {
        /// <summary>
        /// 请求
        /// </summary>
        [XmlElement("gov_doc_request")]
        public string GovDocRequest_ { get; set; }

        /// <summary>
        /// 12121
        /// </summary>
        [XmlElement("test")]
        public string Test { get; set; }
    }
}
