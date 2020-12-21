using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorStationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorStationQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码为城市行政代码。 已支持城市：广州 440100，深圳 440300，杭州330100。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }
    }
}
