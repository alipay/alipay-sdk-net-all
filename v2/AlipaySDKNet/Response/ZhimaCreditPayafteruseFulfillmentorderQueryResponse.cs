using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseFulfillmentorderQueryResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseFulfillmentorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否履约
        /// </summary>
        [XmlElement("fulfillment")]
        public bool Fulfillment { get; set; }

        /// <summary>
        /// 履约单状态
        /// </summary>
        [XmlElement("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// 履约单是否逾期过。已经逾期过的订单，还款后该值依旧是true。
        /// </summary>
        [XmlElement("overdue")]
        public bool Overdue { get; set; }
    }
}
