using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpRatingInnerInitializeResponse.
    /// </summary>
    public class ZhimaCreditEpRatingInnerInitializeResponse : AopResponse
    {
        /// <summary>
        /// 芝麻企业信用客户评估单号，商户应该妥善关联持久化保存该订单号用于后续的对账。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
