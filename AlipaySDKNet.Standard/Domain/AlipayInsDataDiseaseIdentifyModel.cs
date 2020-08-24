using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsDataDiseaseIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDiseaseIdentifyModel : AopObject
    {
        /// <summary>
        /// 疾病处理操作，例如标化(STANDARD)、打标(TAG)
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 疾病名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }
    }
}
