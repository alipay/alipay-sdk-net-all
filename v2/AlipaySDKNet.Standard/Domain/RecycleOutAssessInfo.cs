using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOutAssessInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOutAssessInfo : AopObject
    {
        /// <summary>
        /// 估价结果ID
        /// </summary>
        [XmlElement("estimate_result_id")]
        public string EstimateResultId { get; set; }
    }
}
