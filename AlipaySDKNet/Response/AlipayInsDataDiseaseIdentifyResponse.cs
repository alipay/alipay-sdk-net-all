using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsDataDiseaseIdentifyResponse.
    /// </summary>
    public class AlipayInsDataDiseaseIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 疾病标准编码
        /// </summary>
        [XmlElement("disease_code")]
        public string DiseaseCode { get; set; }

        /// <summary>
        /// 疾病标准名称
        /// </summary>
        [XmlElement("disease_name")]
        public string DiseaseName { get; set; }

        /// <summary>
        /// 疾病标签
        /// </summary>
        [XmlElement("disease_tag")]
        public string DiseaseTag { get; set; }
    }
}
