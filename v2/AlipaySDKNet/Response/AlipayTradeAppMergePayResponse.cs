using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeAppMergePayResponse.
    /// </summary>
    public class AlipayTradeAppMergePayResponse : AopResponse
    {
        /// <summary>
        /// 如果和支付宝约定子订单必须同时支付成功或者同时失败时此参数才存在，取值有以下两种：  1.FINISHED：全部订单付款成功  2.CLOSED：全部订单付款失败</br>
        /// </summary>
        [XmlElement("merge_pay_status")]
        public string MergePayStatus { get; set; }

        /// <summary>
        /// 合并子订单中所有订单的支付结果信息
        /// </summary>
        [XmlArray("order_detail_results")]
        [XmlArrayItem("order_detail_result")]
        public List<OrderDetailResult> OrderDetailResults { get; set; }

        /// <summary>
        /// 如果和支付宝约定子订单必须同时支付成功或者同时失败并且请求时传递了`out_merge_no`时才存在
        /// </summary>
        [XmlElement("out_merge_no")]
        public string OutMergeNo { get; set; }
    }
}
