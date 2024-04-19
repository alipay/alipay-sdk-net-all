using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentDetail : AopObject
    {
        /// <summary>
        /// 履约金额
        /// </summary>
        [XmlElement("fulfillment_amount")]
        public string FulfillmentAmount { get; set; }

        /// <summary>
        /// 履约支付时间
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商户发起履约请求时，传入的out_request_no，标识一次请求的唯一id
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
