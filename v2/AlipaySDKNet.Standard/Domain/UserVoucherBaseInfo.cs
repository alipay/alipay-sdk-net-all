using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserVoucherBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserVoucherBaseInfo : AopObject
    {
        /// <summary>
        /// 若商家券操作过关联商户订单信息，则该字段返回商家券已关联的商户订单号。
        /// </summary>
        [XmlElement("associate_trade_no")]
        public string AssociateTradeNo { get; set; }

        /// <summary>
        /// 领券时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 券可使用的开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_begin_time")]
        public string ValidBeginTime { get; set; }

        /// <summary>
        /// 券可使用的结束时间。 格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 支付宝券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券最大核销次数
        /// </summary>
        [XmlElement("voucher_max_use_times")]
        public long VoucherMaxUseTimes { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [XmlElement("voucher_name")]
        public string VoucherName { get; set; }

        /// <summary>
        /// 券状态。SENDED:可用 USED:已核销(即完全使用), EXPIRED:已过期(只能查询6个月内数据)
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券已核销次数
        /// </summary>
        [XmlElement("voucher_used_times")]
        public long VoucherUsedTimes { get; set; }
    }
}
