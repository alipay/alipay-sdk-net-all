using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserTaxRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserTaxRefundQueryModel : AopObject
    {
        /// <summary>
        /// 二维码值
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 退税申请单号
        /// </summary>
        [XmlElement("refund_biz_no")]
        public string RefundBizNo { get; set; }
    }
}
