using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCmsCdataUploadResponse.
    /// </summary>
    public class AlipayEcoCmsCdataUploadResponse : AopResponse
    {
        /// <summary>
        /// 投放消息ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
