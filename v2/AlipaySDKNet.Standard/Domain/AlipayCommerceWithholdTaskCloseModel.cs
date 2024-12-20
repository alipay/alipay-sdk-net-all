using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWithholdTaskCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWithholdTaskCloseModel : AopObject
    {
        /// <summary>
        /// 代扣任务ID
        /// </summary>
        [XmlElement("withhold_no")]
        public string WithholdNo { get; set; }
    }
}
