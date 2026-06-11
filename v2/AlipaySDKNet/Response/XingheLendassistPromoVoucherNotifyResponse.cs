using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistPromoVoucherNotifyResponse.
    /// </summary>
    public class XingheLendassistPromoVoucherNotifyResponse : AopResponse
    {
        /// <summary>
        /// 机构券ID（星河侧用于幂等使用）
        /// </summary>
        [XmlElement("inst_voucher_id")]
        public string InstVoucherId { get; set; }

        /// <summary>
        /// 请求流水号（幂等使用）
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否可重试
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 星河券Id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
