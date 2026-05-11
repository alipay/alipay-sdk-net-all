using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasMedicalCheckResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasMedicalCheckResponse : AopResponse
    {
        /// <summary>
        /// OCR识别单据号，计费依据，请保留以便排查问题。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 分类结果
        /// </summary>
        [XmlElement("classify_result")]
        public string ClassifyResult { get; set; }
    }
}
