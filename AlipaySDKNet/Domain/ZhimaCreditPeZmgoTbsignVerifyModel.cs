using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoTbsignVerifyModel : AopObject
    {
        /// <summary>
        /// 请求参数，其中paramContent是base64编码串
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
