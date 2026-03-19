using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAgreementShorturlGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementShorturlGenerateModel : AopObject
    {
        /// <summary>
        /// 原始签约长链接
        /// </summary>
        [XmlElement("long_url")]
        public string LongUrl { get; set; }
    }
}
