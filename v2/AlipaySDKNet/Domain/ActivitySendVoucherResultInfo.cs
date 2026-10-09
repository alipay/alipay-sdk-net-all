using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivitySendVoucherResultInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivitySendVoucherResultInfo : AopObject
    {
        /// <summary>
        /// 发放中时返回的具体错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 发放未成功时返回的错误信息
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 发放是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// true 可重试 false 不可重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 服务商发奖后返回的券码列表.
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
