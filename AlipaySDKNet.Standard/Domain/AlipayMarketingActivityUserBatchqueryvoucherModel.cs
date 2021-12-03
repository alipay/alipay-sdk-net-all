using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityUserBatchqueryvoucherModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityUserBatchqueryvoucherModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券归属商户 限制: 1.belong_merchant_id和sender_merchant_id必填一个，且只能二选一。
        /// </summary>
        [XmlElement("belong_merchant_id")]
        public string BelongMerchantId { get; set; }

        /// <summary>
        /// 分页查询页码。  限制: 必须为大于0的整数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 券发放商户 限制: 1.belong_merchant_id和sender_merchant_id必填一个，且只能二选一。
        /// </summary>
        [XmlElement("sender_merchant_id")]
        public string SenderMerchantId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券状态 枚举值  SENDED：可用  USED：已核销  EXPIRED：已过期(可查询6个月内数据)
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
