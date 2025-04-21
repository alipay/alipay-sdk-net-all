using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSelleradmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainFactoringSelleradmitQueryModel : AopObject
    {
        /// <summary>
        /// 基于社会统一信用代码查询门店是否在黑名单内
        /// </summary>
        [XmlElement("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// isv支付宝id
        /// </summary>
        [XmlElement("buyer_alipay_id")]
        public string BuyerAlipayId { get; set; }

        /// <summary>
        /// isv支付宝id
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 门店名单类型,该值由网商提供
        /// </summary>
        [XmlElement("list_type")]
        public string ListType { get; set; }

        /// <summary>
        /// 销售产品码,该值由网商提供
        /// </summary>
        [XmlElement("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 门店支付登录号
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }
    }
}
