using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConfirmResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignConfirmResponse : AopResponse
    {
        /// <summary>
        /// 签约确认返回的JSON信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
