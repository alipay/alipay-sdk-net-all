using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardQuickServiceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CardQuickServiceDTO : AopObject
    {
        /// <summary>
        /// title：卡快捷服务名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// url：卡快捷服务跳转地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
