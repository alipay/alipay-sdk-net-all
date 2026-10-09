using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceZcbEndowmentorderDetailQueryResponse.
    /// </summary>
    public class AlipayFinanceZcbEndowmentorderDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// order_list：查询出来的养老险指定产品的订单列表，EndowmentOrder模型包含：orderId，applyAmount，payTime，taRrequestId 4个字段
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("endowment_order")]
        public List<EndowmentOrder> OrderList { get; set; }

        /// <summary>
        /// total_amount:按照时间区间查询出的订单金额总和，可以用来跟查询出来的明细列表的金额进行核对以发现问题
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// total_count:按照时间区间查询出的订单的总笔数，可以根据该字段与明细列表的笔数进行对比，可以用来发现返回数据笔数是否有问题
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
