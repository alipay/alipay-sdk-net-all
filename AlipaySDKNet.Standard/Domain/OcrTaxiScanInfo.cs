using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OcrTaxiScanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OcrTaxiScanInfo : AopObject
    {
        /// <summary>
        /// 下车时间
        /// </summary>
        [XmlElement("get_off_time")]
        public string GetOffTime { get; set; }

        /// <summary>
        /// 上车时间
        /// </summary>
        [XmlElement("get_on_time")]
        public string GetOnTime { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票时间
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 乘客人
        /// </summary>
        [XmlElement("passenger")]
        public string Passenger { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 乘车距离
        /// </summary>
        [XmlElement("travel_dist")]
        public string TravelDist { get; set; }
    }
}
