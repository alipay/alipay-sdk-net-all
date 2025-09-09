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
        /// 服务商一体化作业主单号
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }
    }
}
