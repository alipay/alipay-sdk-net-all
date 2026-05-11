using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistCarfinValuationQueryResponse.
    /// </summary>
    public class XingheLendassistCarfinValuationQueryResponse : AopResponse
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("car_license")]
        public string CarLicense { get; set; }

        /// <summary>
        /// 优秀档位车辆估值，单位：分
        /// </summary>
        [XmlElement("excellent_valuation_amt")]
        public string ExcellentValuationAmt { get; set; }

        /// <summary>
        /// 良好档位车辆估值，单位：分
        /// </summary>
        [XmlElement("good_valuation_amt")]
        public string GoodValuationAmt { get; set; }

        /// <summary>
        /// 估值时间
        /// </summary>
        [XmlElement("valuation_time")]
        public string ValuationTime { get; set; }
    }
}
