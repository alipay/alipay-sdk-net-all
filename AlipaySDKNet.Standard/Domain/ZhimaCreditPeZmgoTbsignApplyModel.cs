using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoTbsignApplyModel : AopObject
    {
        /// <summary>
        /// 请求参数，其中paramContent为base64编码串
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
