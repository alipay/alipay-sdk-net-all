using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectZftsettlecardDetectResponse.
    /// </summary>
    public class AntMerchantExpandIndirectZftsettlecardDetectResponse : AopResponse
    {
        /// <summary>
        /// 是否一致，一致："true", 不一致："false"
        /// </summary>
        [XmlElement("consistent")]
        public bool Consistent { get; set; }
    }
}
