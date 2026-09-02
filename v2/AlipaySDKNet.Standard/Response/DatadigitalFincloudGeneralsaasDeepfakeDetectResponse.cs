using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasDeepfakeDetectResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasDeepfakeDetectResponse : AopResponse
    {
        /// <summary>
        /// 防伪识别单据号，计费依据，请保留以便排查问题。
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 彩打复印检测结果。Y=通过，N=不通过，S=跳过(未检测)
        /// </summary>
        [XmlElement("colorprint_result")]
        public string ColorprintResult { get; set; }

        /// <summary>
        /// 重复提交检测
        /// </summary>
        [XmlElement("duplicate_upload_result")]
        public string DuplicateUploadResult { get; set; }

        /// <summary>
        /// 截屏检测结果。Y=通过，N=不通过，S=跳过(未检测)
        /// </summary>
        [XmlElement("jieping_result")]
        public string JiepingResult { get; set; }

        /// <summary>
        /// 拍屏检测结果。Y=通过，N=不通过，S=跳过(未检测)
        /// </summary>
        [XmlElement("paiping_result")]
        public string PaipingResult { get; set; }

        /// <summary>
        /// 综合判定。
        /// </summary>
        [XmlElement("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// PS检测。
        /// </summary>
        [XmlElement("ps_result")]
        public string PsResult { get; set; }

        /// <summary>
        /// 相同背景检测结果。Y=通过，N=不通过，S=跳过(未检测)
        /// </summary>
        [XmlElement("same_background_result")]
        public string SameBackgroundResult { get; set; }

        /// <summary>
        /// 相同人脸检测结果。Y=通过，N=不通过，S=跳过(未检测)
        /// </summary>
        [XmlElement("same_face_result")]
        public string SameFaceResult { get; set; }

        /// <summary>
        /// 相同签名检测结果。Y=通过，N=不通过，S=跳过(未检测)
        /// </summary>
        [XmlElement("same_signature_result")]
        public string SameSignatureResult { get; set; }

        /// <summary>
        /// 大模型篡改检测结果，仅增强模式返回。Y=通过，N=不通过，S=跳过(未检测)
        /// </summary>
        [XmlElement("tamper_ps_result")]
        public string TamperPsResult { get; set; }

        /// <summary>
        /// 水印检测结果。Y=通过，N=不通过，S=跳过(未检测)
        /// </summary>
        [XmlElement("watermark_result")]
        public string WatermarkResult { get; set; }
    }
}
