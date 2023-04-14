using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryActivityInfo : AopObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 卡bin的列表
        /// </summary>
        [XmlArray("bank_card_bin_list")]
        [XmlArrayItem("string")]
        public List<string> BankCardBinList { get; set; }

        /// <summary>
        /// 卡类型： "CREDIT"--信用卡， "DEBIT"--借记卡
        /// </summary>
        [XmlElement("bank_card_type")]
        public string BankCardType { get; set; }

        /// <summary>
        /// 银行机构号
        /// </summary>
        [XmlElement("bank_inst_id")]
        public string BankInstId { get; set; }

        /// <summary>
        /// 银行logo
        /// </summary>
        [XmlElement("bank_logo")]
        public string BankLogo { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// USER_VOUCHER   或者DISCOUNT
        /// </summary>
        [XmlElement("delivery_prefer_type")]
        public string DeliveryPreferType { get; set; }

        /// <summary>
        /// 红包可能的最大金额，分
        /// </summary>
        [XmlElement("discount_max_amount")]
        public long DiscountMaxAmount { get; set; }

        /// <summary>
        /// 折扣率，8折80，7.7折 77
        /// </summary>
        [XmlElement("discount_max_ratio")]
        public long DiscountMaxRatio { get; set; }

        /// <summary>
        /// 优惠模式： voucher--红包， reduce--立减
        /// </summary>
        [XmlElement("discount_model")]
        public string DiscountModel { get; set; }

        /// <summary>
        /// 红包门槛金额，分
        /// </summary>
        [XmlElement("discount_threshold_amount")]
        public long DiscountThresholdAmount { get; set; }

        /// <summary>
        /// 优惠类型，满立减（首绑、立减、渠道、多刷）、折扣（立减）
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 红包使用的场景列表
        /// </summary>
        [XmlArray("discount_use_scene_list")]
        [XmlArrayItem("string")]
        public List<string> DiscountUseSceneList { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("gmt_begin")]
        public string GmtBegin { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("voucher_template_id")]
        public string VoucherTemplateId { get; set; }
    }
}
