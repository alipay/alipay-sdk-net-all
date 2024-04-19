using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvTfjsModelversionQueryModel : AopObject
    {
        /// <summary>
        /// tfjs端模型code
        /// </summary>
        [XmlElement("model_code")]
        public string ModelCode { get; set; }
    }
}
