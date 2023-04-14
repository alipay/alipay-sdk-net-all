using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoMycarOrderRefundResponse.
    /// </summary>
    public class AlipayEcoMycarOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 是否成功(T: 成功，F:失败)
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
