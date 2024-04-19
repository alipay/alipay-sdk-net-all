using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainSignIndexCreateResponse.
    /// </summary>
    public class AnttechBlockchainSignIndexCreateResponse : AopResponse
    {
        /// <summary>
        /// 是否通知成功
        /// </summary>
        [XmlElement("publish_success")]
        public bool PublishSuccess { get; set; }
    }
}
