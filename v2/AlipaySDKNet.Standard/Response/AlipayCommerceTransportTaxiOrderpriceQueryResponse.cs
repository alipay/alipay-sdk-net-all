using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiOrderpriceQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiOrderpriceQueryResponse : AopResponse
    {
        /// <summary>
        /// 调度费(单位:分)
        /// </summary>
        [XmlElement("dispatch_amount")]
        public string DispatchAmount { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 返回结果编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 返回结果描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 里程数
        /// </summary>
        [XmlElement("mileage")]
        public string Mileage { get; set; }

        /// <summary>
        /// 燃油附加费(单位:分)
        /// </summary>
        [XmlElement("oil_amount")]
        public string OilAmount { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 行程金额(单位:分)
        /// </summary>
        [XmlElement("trip_amount")]
        public string TripAmount { get; set; }
    }
}
