using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOperateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeNormalpayOperateQueryModel : AopObject
    {
        /// <summary>
        /// 网商订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求流水号；外部平台在请求支付、退款、打款等操作时传入的流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
