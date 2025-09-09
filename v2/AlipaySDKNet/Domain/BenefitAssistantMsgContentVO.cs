using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitAssistantMsgContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitAssistantMsgContentVO : AopObject
    {
        /// <summary>
        /// 活动id，即券id。传入活动id后可支持在群内发小助手优惠券定向消息。请先通过优惠券创建接口创建优惠券<a href="https://opendocs.alipay.com/open/7ad3a7bf_alipay.marketing.activity.ordervoucher.create?scene=a0667e04ac87431eb7e6adc5f13cc8ba&pathHash=3262435d">https://opendocs.alipay.com/open/7ad3a7bf_alipay.marketing.activity.ordervoucher.create?scene=a0667e04ac87431eb7e6adc5f13cc8ba&pathHash=3262435d</a>并获取activity_id优惠券id作为这个入参的值。
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
        /// 人群code，需要通过棋盘人群创建接口<a href="https://opendocs.alipay.com/open/09c10677_alipay.marketing.qipan.crowdoperation.create?pathHash=3d8bad63">https://opendocs.alipay.com/open/09c10677_alipay.marketing.qipan.crowdoperation.create?pathHash=3d8bad63</a>创建并获取返回crowd_code作为这个地方传的人群code参数
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 该字段用于描述本群发消息是否使用券包样式, 若为true, 则群发消息展示使用券包样式, 否则使用普通样式
        /// </summary>
        [XmlElement("multi_coupon")]
        public bool MultiCoupon { get; set; }

        /// <summary>
        /// 小助手定向消息内容，发送小助手时推送给用户的群内权益推荐内容
        /// </summary>
        [XmlElement("recommend_text")]
        public string RecommendText { get; set; }
    }
}
