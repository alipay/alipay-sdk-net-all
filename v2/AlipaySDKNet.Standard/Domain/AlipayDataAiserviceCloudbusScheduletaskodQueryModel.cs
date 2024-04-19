using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusScheduletaskodQueryModel : AopObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
