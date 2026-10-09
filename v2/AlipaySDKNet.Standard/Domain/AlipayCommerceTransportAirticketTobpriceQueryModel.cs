using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAirticketTobpriceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAirticketTobpriceQueryModel : AopObject
    {
        /// <summary>
        /// 到达城市三字码
        /// </summary>
        [XmlElement("arr_city_code")]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// 出发城市三字码
        /// </summary>
        [XmlElement("dep_city_code")]
        public string DepCityCode { get; set; }

        /// <summary>
        /// 出发日期
        /// </summary>
        [XmlElement("dep_date")]
        public string DepDate { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
