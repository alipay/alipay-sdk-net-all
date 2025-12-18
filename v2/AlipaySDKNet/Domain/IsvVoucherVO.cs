using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IsvVoucherVO Data Structure.
    /// </summary>
    [Serializable]
    public class IsvVoucherVO : AopObject
    {
        /// <summary>
        /// 可用现金价值，单位分
        /// </summary>
        [XmlElement("available_cash")]
        public long AvailableCash { get; set; }

        /// <summary>
        /// 可用次数
        /// </summary>
        [XmlElement("available_count")]
        public long AvailableCount { get; set; }

        /// <summary>
        /// 冻结资金，单位分
        /// </summary>
        [XmlElement("freeze_amount")]
        public long FreezeAmount { get; set; }

        /// <summary>
        /// 冻结资金，单位分
        /// </summary>
        [XmlElement("freeze_cash")]
        public long FreezeCash { get; set; }

        /// <summary>
        /// 券生效时间
        /// </summary>
        [XmlElement("gmt_active")]
        public string GmtActive { get; set; }

        /// <summary>
        /// 券失效时间
        /// </summary>
        [XmlElement("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 展期(退款时间超过失效时间，但是未到展期，将失效时间改成展期实际时间)
        /// </summary>
        [XmlElement("gmt_extend")]
        public string GmtExtend { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 回收金额，单位分
        /// </summary>
        [XmlElement("recycle_amount")]
        public long RecycleAmount { get; set; }

        /// <summary>
        /// 描述跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总金额，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 总现金价值，单位分
        /// </summary>
        [XmlElement("total_cash")]
        public long TotalCash { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 已转移金额，单位分
        /// </summary>
        [XmlElement("transfer_amount")]
        public long TransferAmount { get; set; }

        /// <summary>
        /// 已使用次数
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }

        /// <summary>
        /// 券描述
        /// </summary>
        [XmlElement("voucher_description")]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
