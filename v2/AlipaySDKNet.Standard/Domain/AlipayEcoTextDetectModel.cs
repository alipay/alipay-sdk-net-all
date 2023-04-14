using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoTextDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoTextDetectModel : AopObject
    {
        /// <summary>
        /// 检测任务列表
        /// </summary>
        [XmlArray("task")]
        [XmlArrayItem("spi_detection_task")]
        public List<SpiDetectionTask> Task { get; set; }
    }
}
