using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolpaymentBatchqueryResponse.
    /// </summary>
    public class AlipayOverseasTuitionSchoolpaymentBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 商户在支付宝开设的账号ID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 查询缴费订单的返回总数
        /// </summary>
        [XmlElement("payment_order_count")]
        public string PaymentOrderCount { get; set; }

        /// <summary>
        /// 缴费订单列表
        /// </summary>
        [XmlArray("payment_orders")]
        [XmlArrayItem("tuition_inremit_order")]
        public List<TuitionInremitOrder> PaymentOrders { get; set; }

        /// <summary>
        /// 学校批量查询结果状态
        /// </summary>
        [XmlElement("result")]
        public SchoolBatchQueryResult Result { get; set; }
    }
}
