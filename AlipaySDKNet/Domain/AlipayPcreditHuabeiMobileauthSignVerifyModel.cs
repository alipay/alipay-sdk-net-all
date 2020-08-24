using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMobileauthSignVerifyModel : AopObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
