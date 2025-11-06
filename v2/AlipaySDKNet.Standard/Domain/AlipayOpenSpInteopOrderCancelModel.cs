using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopOrderCancelModel : AopObject
    {
        /// <summary>
        /// 一体化作业开通主单号，单号为服务商一体化作业主单创建返回值。
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }
    }
}
