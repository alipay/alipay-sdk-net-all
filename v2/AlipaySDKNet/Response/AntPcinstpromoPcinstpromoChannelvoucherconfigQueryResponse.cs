using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntPcinstpromoPcinstpromoChannelvoucherconfigQueryResponse.
    /// </summary>
    public class AntPcinstpromoPcinstpromoChannelvoucherconfigQueryResponse : AopResponse
    {
        /// <summary>
        /// P站配置的活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 渠道红包活动名称描述
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动状态 CREATED="已创建", PUBLISHING="发布中", PUBLISHED_FAILED="发布失败", GREY="已发布(白名单验证中)", GOING="已发布", PAUSED="已暂停", ENDED="已结束"
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// CREDIT:信用卡 DEBIT:借记卡 DEBIT_CREDIT:借记卡或信用卡
        /// </summary>
        [XmlElement("bank_card_type")]
        public string BankCardType { get; set; }

        /// <summary>
        /// 红包发放时间配置模型
        /// </summary>
        [XmlElement("benefit_send_time")]
        public BenefitSendTimeInfo BenefitSendTime { get; set; }

        /// <summary>
        /// 银行卡卡bin配置，列表类型,以逗号分隔的字符串数组
        /// </summary>
        [XmlArray("card_bin_list")]
        [XmlArrayItem("string")]
        public List<string> CardBinList { get; set; }

        /// <summary>
        /// 红包发放之后的生效时间配置
        /// </summary>
        [XmlElement("coupon_effect_time")]
        public CouponEffectTimeInfo CouponEffectTime { get; set; }

        /// <summary>
        /// 活动发放和消耗信息 请注意：该结果可能存在2个小时之内的时间延迟，特殊情况下可能延迟会更久
        /// </summary>
        [XmlElement("coupon_template_consume_info")]
        public CouponTemplateConsume CouponTemplateConsumeInfo { get; set; }

        /// <summary>
        /// 优惠立减信息配置
        /// </summary>
        [XmlElement("discount_info_config")]
        public DiscountInfoConfigInfo DiscountInfoConfig { get; set; }

        /// <summary>
        /// 最少发放红包份数，比如：88代表此活动最少能发88次红包。
        /// </summary>
        [XmlElement("min_send_count")]
        public long MinSendCount { get; set; }

        /// <summary>
        /// 活动总预算值，以分为单位。如果值为999，则说明是9.99元预算
        /// </summary>
        [XmlElement("total_budget")]
        public long TotalBudget { get; set; }

        /// <summary>
        /// 红包使用说明文案
        /// </summary>
        [XmlArray("user_instruction_list")]
        [XmlArrayItem("string")]
        public List<string> UserInstructionList { get; set; }
    }
}
