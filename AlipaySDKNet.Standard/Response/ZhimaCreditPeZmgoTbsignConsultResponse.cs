using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConsultResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignConsultResponse : AopResponse
    {
        /// <summary>
        /// 签约咨询返回的JSON信息
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
