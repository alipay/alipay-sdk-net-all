using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayGotoneMessageMailSendResponse.
    /// </summary>
    public class AlipayGotoneMessageMailSendResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
