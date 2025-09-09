using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelRecognitionCheckResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelRecognitionCheckResponse : AopResponse
    {
        /// <summary>
        /// 文件上传afts后返回id
        /// </summary>
        [XmlElement("afts_id")]
        public string AftsId { get; set; }

        /// <summary>
        /// 算法返回的结果，客户端无须关注此处
        /// </summary>
        [XmlElement("classify_result")]
        public string ClassifyResult { get; set; }

        /// <summary>
        /// 压缩图片地址
        /// </summary>
        [XmlElement("compressed_pic_url")]
        public string CompressedPicUrl { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        [XmlElement("pic_type")]
        public string PicType { get; set; }

        /// <summary>
        /// 查询内容
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 图片识别返回值为false时，取该值，提示用户
        /// </summary>
        [XmlElement("tips")]
        public string Tips { get; set; }

        /// <summary>
        /// 文件可访问url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// true表示是需要的内容，false表示无关的, verificationResult= false时，取该tips值，提示用户
        /// </summary>
        [XmlElement("verification_result")]
        public bool VerificationResult { get; set; }
    }
}
