using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CouponMsgVO Data Structure.
    /// </summary>
    [Serializable]
    public class CouponMsgVO : AopObject
    {
        /// <summary>
        /// 活动id，即券id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动id列表
        /// </summary>
        [XmlArray("activity_id_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityIdList { get; set; }

        /// <summary>
        /// 图片id
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 长文本介绍文案
        /// </summary>
        [XmlElement("long_introduce_text")]
        public string LongIntroduceText { get; set; }

        /// <summary>
        /// 该字段用于描述本群发消息是否使用券包样式, 若为true, 则群发消息展示使用券包样式, 否则使用普通样式
        /// </summary>
        [XmlElement("multi_coupon")]
        public bool MultiCoupon { get; set; }

        /// <summary>
        /// 短文本介绍文案列表
        /// </summary>
        [XmlArray("short_introduce_text_list")]
        [XmlArrayItem("string")]
        public List<string> ShortIntroduceTextList { get; set; }

        /// <summary>
        /// 推送的消息文案标题（参考：好物分享来咯！）
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
