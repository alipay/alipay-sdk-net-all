using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMobileauthSignConfirmModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
