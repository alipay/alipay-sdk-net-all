using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAuthenticationTokenVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAuthenticationTokenVerifyModel : AopObject
    {
        /// <summary>
        /// token数据
        /// </summary>
        [XmlElement("token_data")]
        public string TokenData { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
