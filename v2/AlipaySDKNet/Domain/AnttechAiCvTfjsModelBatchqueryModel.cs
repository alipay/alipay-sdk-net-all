using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvTfjsModelBatchqueryModel : AopObject
    {
        /// <summary>
        /// 模型信息，包含模型code和版本号，单组模型code和版本通过英文分号(:)分隔，多组模型信息之间用英文分号(;)分隔
        /// </summary>
        [XmlElement("model_info")]
        public string ModelInfo { get; set; }
    }
}
