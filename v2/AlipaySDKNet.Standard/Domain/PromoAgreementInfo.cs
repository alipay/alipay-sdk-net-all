using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoAgreementInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoAgreementInfo : AopObject
    {
        /// <summary>
        /// 活动的协议名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 活动的协议链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
