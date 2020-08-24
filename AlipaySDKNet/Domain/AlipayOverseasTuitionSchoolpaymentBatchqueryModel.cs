using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolpaymentBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTuitionSchoolpaymentBatchqueryModel : AopObject
    {
        /// <summary>
        /// ISV入驻签约PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 一次最多输入100个订单组
        /// </summary>
        [XmlArray("payment_orders")]
        [XmlArrayItem("tuition_query_order")]
        public List<TuitionQueryOrder> PaymentOrders { get; set; }
    }
}
