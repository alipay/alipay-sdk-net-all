using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoBillQueryModel : AopObject
    {
        /// <summary>
        /// 出账日期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 生态供应商编号
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 生态供应商店铺编号
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }
    }
}
