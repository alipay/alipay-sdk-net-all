using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillchargeOrderBatchcreateResponse.
    /// </summary>
    public class AlipayEbppBillchargeOrderBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 主订单流水号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 主订单状态 I-等待付款 P-已支付 C-单据关闭
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子订单列
        /// </summary>
        [XmlArray("sub_order_list")]
        [XmlArrayItem("sub_order_info")]
        public List<SubOrderInfo> SubOrderList { get; set; }

        /// <summary>
        /// 总支付金额
        /// </summary>
        [XmlElement("total_pay_amount")]
        public string TotalPayAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
