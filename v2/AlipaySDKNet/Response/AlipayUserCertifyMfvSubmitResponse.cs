using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertifyMfvSubmitResponse.
    /// </summary>
    public class AlipayUserCertifyMfvSubmitResponse : AopResponse
    {
        /// <summary>
        /// extend_map是核验的扩展数据，根据不同的scene_id，返回的数据不同。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }
    }
}
