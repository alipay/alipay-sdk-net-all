using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectBindQrcodecreateResponse.
    /// </summary>
    public class AntMerchantExpandIndirectBindQrcodecreateResponse : AopResponse
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 申请单是否已存在
        /// </summary>
        [XmlElement("has_apply")]
        public string HasApply { get; set; }

        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 二维码图片的可访问url。有效期24h
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 状态。TRUE创建成功，FALSE创建失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
