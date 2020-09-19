using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OcrPlaneScanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OcrPlaneScanInfo : AopObject
    {
        /// <summary>
        /// 目的地
        /// </summary>
        [XmlElement("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 乘机日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 出发地
        /// </summary>
        [XmlElement("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// 乘客
        /// </summary>
        [XmlElement("passenger")]
        public string Passenger { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 明细事由
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 飞机舱位
        /// </summary>
        [XmlElement("seat_class")]
        public string SeatClass { get; set; }
    }
}
