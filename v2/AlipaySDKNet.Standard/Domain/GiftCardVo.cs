using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftCardVo Data Structure.
    /// </summary>
    [Serializable]
    public class GiftCardVo : AopObject
    {
        /// <summary>
        /// 可用余额
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 面额
        /// </summary>
        [XmlElement("denomination")]
        public string Denomination { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        [XmlElement("effective_period")]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 礼品卡实例id
        /// </summary>
        [XmlElement("gift_card_instance_no")]
        public string GiftCardInstanceNo { get; set; }

        /// <summary>
        /// 卡实例状态
        /// </summary>
        [XmlElement("gift_card_instance_status")]
        public string GiftCardInstanceStatus { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("gift_card_name")]
        public string GiftCardName { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("gift_card_no")]
        public string GiftCardNo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("gift_card_status")]
        public string GiftCardStatus { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 采购方id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 子账户详情
        /// </summary>
        [XmlElement("sub_account_info")]
        public CardSubAccountResult SubAccountInfo { get; set; }

        /// <summary>
        /// 卡绑定的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 有效日期
        /// </summary>
        [XmlElement("valid_period")]
        public string ValidPeriod { get; set; }
    }
}
