using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopOrderConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopOrderConfirmModel : AopObject
    {
        /// <summary>
        /// 选择异步提交，根据alipay.open.sp.inteop.order.query接口查询订单提交结果
        /// </summary>
        [XmlElement("async_submit")]
        public bool AsyncSubmit { get; set; }

        /// <summary>
        /// 服务商一体化作业主单号
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }
    }
}
