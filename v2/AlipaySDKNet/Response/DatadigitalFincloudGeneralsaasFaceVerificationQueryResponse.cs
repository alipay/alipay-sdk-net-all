using System;
using System.Xml.Serialization;

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
        /// 是否为攻击，true：本次判定为攻击；false：非攻击。
        /// </summary>
        [XmlElement("attack_flag")]
        public string AttackFlag { get; set; }

        /// <summary>
        /// 人脸检测单据状态。PROCESSING：初始化；SUCCESS：检测成功；FAIL：检测失败
        /// </summary>
        [XmlElement("certify_state")]
        public string CertifyState { get; set; }

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
