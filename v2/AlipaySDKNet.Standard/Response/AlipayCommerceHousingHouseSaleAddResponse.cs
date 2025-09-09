using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingHouseSaleAddResponse.
    /// </summary>
    public class AlipayCommerceHousingHouseSaleAddResponse : AopResponse
    {
        /// <summary>
        /// 房源id
        /// </summary>
        [XmlElement("housing_id")]
        public string HousingId { get; set; }
    }
}
