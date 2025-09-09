using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopOrderQueryModel : AopObject
    {
        /// <summary>
        /// 一体化作业业务开通主单号
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }
    }
}
