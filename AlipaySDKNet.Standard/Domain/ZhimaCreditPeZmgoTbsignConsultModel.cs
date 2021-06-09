using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoTbsignConsultModel : AopObject
    {
        /// <summary>
        /// 请求参数，其中paramContent的值为base64编码串
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
