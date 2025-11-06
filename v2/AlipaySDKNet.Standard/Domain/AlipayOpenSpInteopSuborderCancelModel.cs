using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopSuborderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopSuborderCancelModel : AopObject
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 一体化作业开通主单号，单号为服务商一体化作业主单创建返回值。
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 服务商一体化作业子项单号，单号为一体化作业子项开通成功返回值。
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }
    }
}
