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
        /// 商户号
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [XmlElement("order_content")]
        public IsvBizOpenOrderContent OrderContent { get; set; }

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
        /// 子单列表
        /// </summary>
        [XmlArray("sub_merchant_orders")]
        [XmlArrayItem("isv_sub_merchant_order_v_o")]
        public List<IsvSubMerchantOrderVO> SubMerchantOrders { get; set; }

        /// <summary>
        /// 待办url
        /// </summary>
        [XmlElement("wait_process_task_url")]
        public string WaitProcessTaskUrl { get; set; }
    }
}
