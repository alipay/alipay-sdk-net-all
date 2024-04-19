using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtWelfarefoundationVolunteersBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtWelfarefoundationVolunteersBatchqueryModel : AopObject
    {
        /// <summary>
        /// 人员ID
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("string")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 蚂蚁公益基金会
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
