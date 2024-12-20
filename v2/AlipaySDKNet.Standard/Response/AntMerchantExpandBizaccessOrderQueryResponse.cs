using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandBizaccessOrderQueryResponse.
    /// </summary>
    public class AntMerchantExpandBizaccessOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlArray("fail_reasons")]
        [XmlArrayItem("isv_biz_open_order_fail_reason")]
        public List<IsvBizOpenOrderFailReason> FailReasons { get; set; }

        /// <summary>
        /// 业务开通主单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 用于表示申请单的状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 待办url
        /// </summary>
        [XmlElement("wait_process_task_url")]
        public string WaitProcessTaskUrl { get; set; }
    }
}
