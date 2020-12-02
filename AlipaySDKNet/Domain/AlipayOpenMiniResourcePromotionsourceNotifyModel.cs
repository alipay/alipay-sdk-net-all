using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniResourcePromotionsourceNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniResourcePromotionsourceNotifyModel : AopObject
    {
        /// <summary>
        /// 媒体唤起时传入的支付宝id
        /// </summary>
        [XmlElement("author_id")]
        public string AuthorId { get; set; }

        /// <summary>
        /// 媒体唤起时提供的额外参数值列表，这里可能有多个值，打平以后拼入。即url_decode(authcbparams)
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 推广位id
        /// </summary>
        [XmlElement("promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// 推广位名称
        /// </summary>
        [XmlElement("promotion_name")]
        public string PromotionName { get; set; }

        /// <summary>
        /// 媒体来源，标识调用方
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
