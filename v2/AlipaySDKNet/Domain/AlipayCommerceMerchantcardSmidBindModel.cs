using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardSmidBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardSmidBindModel : AopObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 二级商户id
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
