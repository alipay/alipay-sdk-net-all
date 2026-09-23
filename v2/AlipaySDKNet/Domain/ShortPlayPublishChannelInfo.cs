using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlayPublishChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlayPublishChannelInfo : AopObject
    {
        /// <summary>
        /// CCID，该渠道的短剧标识
        /// </summary>
        [XmlElement("cc_id")]
        public string CcId { get; set; }

        /// <summary>
        /// 渠道。0 商家小程序；1 生活号。
        /// </summary>
        [XmlElement("channel")]
        public long Channel { get; set; }

        /// <summary>
        /// 统一审核任务ID
        /// </summary>
        [XmlElement("review_id")]
        public string ReviewId { get; set; }

        /// <summary>
        /// 发布状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
