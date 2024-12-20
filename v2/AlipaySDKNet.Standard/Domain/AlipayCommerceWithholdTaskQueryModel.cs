using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWithholdTaskQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWithholdTaskQueryModel : AopObject
    {
        /// <summary>
        /// 代扣任务ID
        /// </summary>
        [XmlElement("withhold_no")]
        public string WithholdNo { get; set; }
    }
}
