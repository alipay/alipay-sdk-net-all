using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEvaluationQueryResponse.
    /// </summary>
    public class ZhimaCreditEpEvaluationQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("evaluation_order_info")]
        public List<EvaluationOrderInfo> OrderList { get; set; }
    }
}
