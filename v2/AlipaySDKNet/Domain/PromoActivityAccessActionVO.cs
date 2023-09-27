using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoActivityAccessActionVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoActivityAccessActionVO : AopObject
    {
        /// <summary>
        /// 下一步应该怎么做
        /// </summary>
        [XmlElement("action_text")]
        public string ActionText { get; set; }

        /// <summary>
        /// 行动链接
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }
    }
}
