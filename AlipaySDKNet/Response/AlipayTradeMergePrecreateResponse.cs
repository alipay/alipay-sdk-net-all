using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeMergePrecreateResponse.
    /// </summary>
    public class AlipayTradeMergePrecreateResponse : AopResponse
    {
        /// <summary>
        /// 合并子订单中所有订单的预创建结果
        /// </summary>
        [XmlArray("order_detail_results")]
        [XmlArrayItem("pre_order_result")]
        public List<PreOrderResult> OrderDetailResults { get; set; }

        /// <summary>
        /// 如果和支付宝约定子订单必须同时支付成功或者同时失败并且请求时传递了out_merge_no时才存在
        /// </summary>
        [XmlElement("out_merge_no")]
        public string OutMergeNo { get; set; }

        /// <summary>
        /// 如果预创建成功，支付宝返回该预下单号，后续商户使用该预下单号请求支付宝支付接口
        /// </summary>
        [XmlElement("pre_order_no")]
        public string PreOrderNo { get; set; }
    }
}
