using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceVerificationQueryResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceVerificationQueryResponse : AopResponse
    {
        /// <summary>
        /// base64过后的图片图片
        /// </summary>
        [XmlElement("alive_photo")]
        public string AlivePhoto { get; set; }

        /// <summary>
        /// 本次认证是否存在安全风险，true：检测到安全风险；false：未检测到安全风险。
        /// </summary>
        [XmlElement("attack_flag")]
        public string AttackFlag { get; set; }

        /// <summary>
        /// 人脸认证状态。PROCESSING：初始化；SUCCESS：认证通过；FAIL：认证不通过。
        /// </summary>
        [XmlElement("certify_state")]
        public string CertifyState { get; set; }

        /// <summary>
        /// 人脸认证元数据信息
        /// </summary>
        [XmlElement("meta_info")]
        public OpenCertifyMetaInfo MetaInfo { get; set; }

        /// <summary>
        /// double值，人脸图片质量分
        /// </summary>
        [XmlElement("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// double值，活体检测结果分数
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
