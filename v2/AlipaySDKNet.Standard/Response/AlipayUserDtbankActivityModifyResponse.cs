using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankActivityModifyResponse.
    /// </summary>
    public class AlipayUserDtbankActivityModifyResponse : AopResponse
    {
        /// <summary>
        /// 活动修改的结果，INIT表示处理中，SUCCESS表示成功，FAILED表示失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
