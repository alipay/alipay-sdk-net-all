using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateUseInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateUseInfoDTO : AopObject
    {
        /// <summary>
        /// 核销信息
        /// </summary>
        [XmlElement("certificate_use_info")]
        public MiniCertificateUseInfo CertificateUseInfo { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item_info")]
        public MiniItemInfo ItemInfo { get; set; }

        /// <summary>
        /// 订单基础信息
        /// </summary>
        [XmlElement("order_base_info")]
        public OrderBaseInfo OrderBaseInfo { get; set; }

        /// <summary>
        /// 价格信息
        /// </summary>
        [XmlElement("price_info")]
        public MiniPriceInfoDTO PriceInfo { get; set; }

        /// <summary>
        /// 退款信息
        /// </summary>
        [XmlElement("refund_info")]
        public MiniRefundInfo RefundInfo { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [XmlElement("status_info")]
        public MiniStatusInfo StatusInfo { get; set; }

        /// <summary>
        /// 使用人信息
        /// </summary>
        [XmlElement("user_info")]
        public MiniUserInfo UserInfo { get; set; }
    }
}
