using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocTransferprecheckCheckavailableResponse.
    /// </summary>
    public class AnttechNftCtocTransferprecheckCheckavailableResponse : AopResponse
    {
        /// <summary>
        /// 前置校验id
        /// </summary>
        [XmlElement("pre_check_id")]
        public string PreCheckId { get; set; }
    }
}
