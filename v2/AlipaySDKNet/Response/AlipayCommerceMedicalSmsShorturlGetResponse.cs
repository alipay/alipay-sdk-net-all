using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalSmsShorturlGetResponse.
    /// </summary>
    public class AlipayCommerceMedicalSmsShorturlGetResponse : AopResponse
    {
        /// <summary>
        /// 短链
        /// </summary>
        [XmlElement("msg_url")]
        public string MsgUrl { get; set; }
    }
}
