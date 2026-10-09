using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingSrtaNonanonymousQueryResponse.
    /// </summary>
    public class AnttechMorseMarketingSrtaNonanonymousQueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁侧返回的唯一标识
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 曝光命中的活动唯一标识，主要数据回调
        /// </summary>
        [XmlElement("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 活动文案
        /// </summary>
        [XmlElement("campaign_text")]
        public string CampaignText { get; set; }

        /// <summary>
        /// 活动文案类型，如binding(绑卡)，activating（促活）
        /// </summary>
        [XmlElement("campaign_text_type")]
        public string CampaignTextType { get; set; }

        /// <summary>
        /// 优惠渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 命中后返回的跳转链接，配置跳转链接时必选
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 最大优惠金额
        /// </summary>
        [XmlElement("max_amount")]
        public string MaxAmount { get; set; }

        /// <summary>
        /// 最小优惠金额
        /// </summary>
        [XmlElement("min_amount")]
        public string MinAmount { get; set; }

        /// <summary>
        /// 是否可享受立减
        /// </summary>
        [XmlElement("need_deduct")]
        public bool NeedDeduct { get; set; }

        /// <summary>
        /// 奖品类型. 打折 满减 单笔减 阶梯优惠 抹零优惠 随机立减 订单金额减至 折扣方式 DISCOUNT("discount", "折扣方式"), REDUCE("reduce", "满立减"), SINGLE("single", "单笔减"), STAGED_DISCOUNT("staged_discount", "阶梯优惠"), RESET_ZERO_DISCOUNT("reset_zero_discount", "抹零优惠"), RANDOM_DISCOUNT("random", "随机立减"); REDUCE_TO_DISCOUNT("reduce_to_discount","订单金额减至 ")
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 优惠门槛，需要满此金额才可优惠
        /// </summary>
        [XmlElement("threshold")]
        public string Threshold { get; set; }
    }
}
