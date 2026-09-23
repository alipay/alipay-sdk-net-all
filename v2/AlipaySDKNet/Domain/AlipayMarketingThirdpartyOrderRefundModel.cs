using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingThirdpartyOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingThirdpartyOrderRefundModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("task_id_list")]
        [XmlArrayItem("string")]
        public List<string> TaskIdList { get; set; }
    }
}
