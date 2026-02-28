using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VerifyConfigAuthorizationPageConfig Data Structure.
    /// </summary>
    [Serializable]
    public class VerifyConfigAuthorizationPageConfig : AopObject
    {
        /// <summary>
        /// 授权logoUrl
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 授权主标题
        /// </summary>
        [XmlElement("main_title")]
        public string MainTitle { get; set; }

        /// <summary>
        /// 是否校验间隔限制 -1代表不限制，正数代表限制，单位秒
        /// </summary>
        [XmlElement("verify_interval_limit")]
        public string VerifyIntervalLimit { get; set; }
    }
}
