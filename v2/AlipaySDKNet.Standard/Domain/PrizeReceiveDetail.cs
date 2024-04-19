using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PrizeReceiveDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeReceiveDetail : AopObject
    {
        /// <summary>
        /// 发奖单据号
        /// </summary>
        [XmlElement("send_order_id")]
        public string SendOrderId { get; set; }

        /// <summary>
        /// 券创建时间
        /// </summary>
        [XmlElement("voucher_gmt_create")]
        public string VoucherGmtCreate { get; set; }

        /// <summary>
        /// 券过期时间
        /// </summary>
        [XmlElement("voucher_gmt_expired")]
        public string VoucherGmtExpired { get; set; }

        /// <summary>
        /// 券变更时间
        /// </summary>
        [XmlElement("voucher_gmt_modified")]
        public string VoucherGmtModified { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [XmlElement("voucher_template_id")]
        public string VoucherTemplateId { get; set; }
    }
}
