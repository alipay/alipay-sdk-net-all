using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpOperationQrcodeQueryResponse.
    /// </summary>
    public class AlipayOpenSpOperationQrcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝操作批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 二维码图片地址。urlEncode处理过
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
