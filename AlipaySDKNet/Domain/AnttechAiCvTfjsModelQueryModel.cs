using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvTfjsModelQueryModel : AopObject
    {
        /// <summary>
        /// 模型服务code，模型服务唯一标示
        /// </summary>
        [XmlElement("model_code")]
        public string ModelCode { get; set; }

        /// <summary>
        /// 模型对应版本号
        /// </summary>
        [XmlElement("model_version")]
        public string ModelVersion { get; set; }
    }
}
