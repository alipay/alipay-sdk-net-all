using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherVerifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherVerifyInfo : AopObject
    {
        /// <summary>
        /// 卡号，例如年卡卡号 年卡商品时，此字段必填
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 有效期，例如年卡有效期至2023-10-01 00:00:00 年卡商品时，此字段必填
        /// </summary>
        [XmlElement("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 外部商品id
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 外部凭证id
        /// </summary>
        [XmlElement("out_voucher_id")]
        public string OutVoucherId { get; set; }

        /// <summary>
        /// 服务链接地址 年卡商品时，此字段必填
        /// </summary>
        [XmlElement("service_link_url")]
        public string ServiceLinkUrl { get; set; }
    }
}
