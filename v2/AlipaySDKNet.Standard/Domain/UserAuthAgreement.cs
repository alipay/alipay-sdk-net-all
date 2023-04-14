using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserAuthAgreement Data Structure.
    /// </summary>
    [Serializable]
    public class UserAuthAgreement : AopObject
    {
        /// <summary>
        /// 协议名称
        /// </summary>
        [XmlElement("agreement_name")]
        public string AgreementName { get; set; }

        /// <summary>
        /// 可下载协议地址
        /// </summary>
        [XmlElement("download_link")]
        public string DownloadLink { get; set; }

        /// <summary>
        /// 展示链接地址
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }
    }
}
