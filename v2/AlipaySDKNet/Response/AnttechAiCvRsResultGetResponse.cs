using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvRsResultGetResponse.
    /// </summary>
    public class AnttechAiCvRsResultGetResponse : AopResponse
    {
        /// <summary>
        /// 各种类型的预测结果值
        /// </summary>
        [XmlElement("predict_res")]
        public string PredictRes { get; set; }
    }
}
