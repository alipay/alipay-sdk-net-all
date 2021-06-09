using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoTbsignConfirmModel : AopObject
    {
        /// <summary>
        /// 请求参数，其中paramContent为base64编码串
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
