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
        /// 门店id，门店是归属于pid的，不是smid下的门店
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 二级商户id，注意smid需要是pid下的
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }
    }
}
