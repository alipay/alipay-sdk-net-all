using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantEscrowApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantEscrowApplyModel : AopObject
    {
        /// <summary>
        /// 经营信息
        /// </summary>
        [XmlElement("business_info")]
        public EscrowBusinessInfo BusinessInfo { get; set; }

        /// <summary>
        /// 银行卡信息
        /// </summary>
        [XmlElement("card_info")]
        public EscrowSettleCardInfo CardInfo { get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [XmlElement("contact_info")]
        public EscrowContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 认证信息
        /// </summary>
        [XmlElement("license")]
        public EscrowLicense License { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 平台ppid
        /// </summary>
        [XmlElement("platform_partner_id")]
        public string PlatformPartnerId { get; set; }

        /// <summary>
        /// 卖家店铺名称
        /// </summary>
        [XmlElement("seller_shop_name")]
        public string SellerShopName { get; set; }

        /// <summary>
        /// 1 企业, 2 个人
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }

        /// <summary>
        /// 支付宝用户uid，16位2088
        /// </summary>
        [XmlElement("seller_user_id")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 支付宝用户名称
        /// </summary>
        [XmlElement("seller_user_name")]
        public string SellerUserName { get; set; }
    }
}
