using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCertificateCertificationPrepareuseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCertificateCertificationPrepareuseModel : AopObject
    {
        /// <summary>
        /// 用户出示的核销二维码下方的12位券码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 是否启用跨单核销。 该值默认为false 用户多次下单购买相同商品，当cross_order为true时，传入任一订单二维码信息可以获取用户多次购买该商品的所有有效券码信息。
        /// </summary>
        [XmlElement("cross_order")]
        public bool CrossOrder { get; set; }

        /// <summary>
        /// 根据用户出示的核销二维码解析出来的标识
        /// </summary>
        [XmlElement("encrypted_data")]
        public string EncryptedData { get; set; }
    }
}
