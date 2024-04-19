using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfSignInvalidResponse.
    /// </summary>
    public class AlipayEbppJfSignInvalidResponse : AopResponse
    {
        /// <summary>
        /// 解约结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 解约结果的描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
