using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportMapstudioOverlapratioQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportMapstudioOverlapratioQueryModel : AopObject
    {
        /// <summary>
        /// 城市区域编码，例如南京：320100
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }
    }
}
