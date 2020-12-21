using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountNegativecardSendResponse.
    /// </summary>
    public class AlipayUserAccountNegativecardSendResponse : AopResponse
    {
        /// <summary>
        /// 结果码。SUCCESS：发送成功。
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
