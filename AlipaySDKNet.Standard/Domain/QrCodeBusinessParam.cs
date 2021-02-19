using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QrCodeBusinessParam Data Structure.
    /// </summary>
    [Serializable]
    public class QrCodeBusinessParam : AopObject
    {
        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商户SMID
        /// </summary>
        [XmlElement("merchant_smid")]
        public string MerchantSmid { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merhcant_name")]
        public string MerhcantName { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 商户支付宝门店编号
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
