using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingShopinfoCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryCareertrainingShopinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
