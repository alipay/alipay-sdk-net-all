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
        /// 活动 id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券归属商户
        /// </summary>
        [XmlElement("belong_merchant_id")]
        public string BelongMerchantId { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        [XmlElement("merchant_access_mode")]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 券发放商户
        /// </summary>
        [XmlElement("sender_merchant_id")]
        public string SenderMerchantId { get; set; }

        /// <summary>
        /// 支付宝用户 id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券状态，其中已过期状态可查询6个月内的数据
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
