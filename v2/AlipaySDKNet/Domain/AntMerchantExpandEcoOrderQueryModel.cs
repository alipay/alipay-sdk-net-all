using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoOrderQueryModel : AopObject
    {
        /// <summary>
        /// 交易平台
        /// </summary>
        [XmlElement("busi_platform")]
        public string BusiPlatform { get; set; }

        /// <summary>
        /// 生态供应商编号
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 交易平台订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 生态供应商店铺编号
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }
    }
}
