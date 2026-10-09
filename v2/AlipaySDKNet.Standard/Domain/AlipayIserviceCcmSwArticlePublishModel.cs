using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwArticlePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmSwArticlePublishModel : AopObject
    {
        /// <summary>
        /// 知识点id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 生效 PUBLISHED，失效 EXPIRED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
