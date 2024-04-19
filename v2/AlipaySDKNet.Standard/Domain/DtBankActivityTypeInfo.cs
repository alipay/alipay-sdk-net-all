using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankActivityTypeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankActivityTypeInfo : AopObject
    {
        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 首绑有礼活动信息，activity_type为FIRST_BIND_GIFT_CARD时有值
        /// </summary>
        [XmlElement("first_bind_card_gift_info")]
        public DtBankFirstBindCardGiftInfo FirstBindCardGiftInfo { get; set; }

        /// <summary>
        /// 通用渠道红包信息，activity_type为VOUCHER时有值
        /// </summary>
        [XmlElement("voucher_info")]
        public DtBankVoucherInfo VoucherInfo { get; set; }
    }
}
