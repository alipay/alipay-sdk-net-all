using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringKmsOrderSyncResponse.
    /// </summary>
    public class KoubeiCateringKmsOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 开发者提示信息, 如果重复推单或重复退款, 会通过这个字段提示,  无其他业务作用.
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
