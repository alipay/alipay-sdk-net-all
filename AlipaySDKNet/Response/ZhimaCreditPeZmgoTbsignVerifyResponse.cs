using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignVerifyResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignVerifyResponse : AopResponse
    {
        /// <summary>
        /// 签约核身返回的JSON信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
