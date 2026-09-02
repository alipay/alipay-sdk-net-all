using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasDeepfakeNewCheckResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasDeepfakeNewCheckResponse : AopResponse
    {
        /// <summary>
        /// 防伪识别单据号，计费依据，请保留以便排查问题。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 彩打复印检测结果。Y=通过，N=不通过，S=跳过（未检测）。
        /// </summary>
        [XmlElement("colorprint_result")]
        public DeepFakeResult ColorprintResult { get; set; }

        /// <summary>
        /// 元数据异常检测结果。
        /// </summary>
        [XmlElement("exif_ps_result")]
        public string ExifPsResult { get; set; }

        /// <summary>
        /// 截屏检测结果。Y=通过，N=不通过，S=跳过（未检测）。
        /// </summary>
        [XmlElement("jieping_result")]
        public DeepFakeResult JiepingResult { get; set; }

        /// <summary>
        /// 拍屏检测结果。Y=通过，N=不通过，S=跳过（未检测）。
        /// </summary>
        [XmlElement("paiping_result")]
        public DeepFakeResult PaipingResult { get; set; }

        /// <summary>
        /// 综合判定。
        /// </summary>
        [XmlElement("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// PS检测结果。Y=通过，N=不通过，S=跳过（未检测）；检测不通过时返回fake_reason。
        /// </summary>
        [XmlElement("ps_result")]
        public DeepFakeResult PsResult { get; set; }

        /// <summary>
        /// 大模型篡改检测结果。Y=通过，N=不通过，S=跳过（未检测）。
        /// </summary>
        [XmlElement("tamper_ps_result")]
        public DeepFakeResult TamperPsResult { get; set; }
    }
}
