using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherQueryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherQueryInfo : AopObject
    {
        /// <summary>
        /// 券生效时间
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 券面额，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 券剩余可用金额，单位为元
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 券失效时间,超过此时间券将不能被使用
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 券发放时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 当前券券已经使用的次数
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券状态 ENABLED：可使用。（注意，如果当前时间在券有效期之前，状态还是可用）  EXPIRED：已过期（在券面额没有用完的情况下）  USED：已经使用（券面额已经全部是使用完，不能再使用）  DELETE：已删除 DISABLE：不可用
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
