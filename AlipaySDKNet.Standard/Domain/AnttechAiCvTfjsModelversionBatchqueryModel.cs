using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvTfjsModelversionBatchqueryModel : AopObject
    {
        /// <summary>
        /// tfjs端模型code，多个code之间用英文逗号分隔
        /// </summary>
        [XmlElement("model_code")]
        public string ModelCode { get; set; }
    }
}
