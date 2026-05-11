using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantEscrowApplyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantEscrowApplyModifyModel : AopObject
    {
        /// <summary>
        /// 支付宝主单号
        /// </summary>
        [XmlElement("ant_merchant_order_no")]
        public string AntMerchantOrderNo { get; set; }

        /// <summary>
        /// 银行卡信息
        /// </summary>
        [XmlElement("card_info")]
        public EscrowSettleCardInfo CardInfo { get; set; }

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
        /// 支付宝用户uid，16位2088
        /// </summary>
        [XmlElement("seller_user_id")]
        public string SellerUserId { get; set; }
    }
}
