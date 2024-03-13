using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceBusinessAnalysisCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceBusinessAnalysisCreateResponse : AopResponse
    {
        /// <summary>
        /// 商圈分析任务ID，唯一
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
