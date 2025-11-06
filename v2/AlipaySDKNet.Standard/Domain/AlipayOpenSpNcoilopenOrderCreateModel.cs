using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNcoilopenOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNcoilopenOrderCreateModel : AopObject
    {
        /// <summary>
        /// 快递发送方式，有普通快递和顺丰快递
        /// </summary>
        [XmlElement("delivery_plan")]
        public string DeliveryPlan { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [XmlElement("order_describe")]
        public string OrderDescribe { get; set; }

        /// <summary>
        /// 返佣pid，非必要不要添加，如需要，联系产品负责人
        /// </summary>
        [XmlElement("rebate_pid")]
        public string RebatePid { get; set; }

        /// <summary>
        /// 流水id，通过调用alipay.open.sp.ncoilopen.reference.create接口返回值中获取reference_id
        /// </summary>
        [XmlElement("reference_id")]
        public string ReferenceId { get; set; }
    }
}
