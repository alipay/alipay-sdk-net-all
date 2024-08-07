using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCheckQueryResponse.
    /// </summary>
    public class DatadigitalFincloudGeneralsaasFaceCheckQueryResponse : AopResponse
    {
        /// <summary>
        /// 如果设置了need_alive_photo的值不为N，则该字段返回人脸照片的base64编码字符串。
        /// </summary>
        [XmlElement("alive_photo")]
        public string AlivePhoto { get; set; }

        /// <summary>
        /// 已废弃
        /// </summary>
        [XmlElement("attack_flag")]
        public string AttackFlag { get; set; }

        /// <summary>
        /// PROCESSING：初始化；SUCCESS：检测成功；FAIL：检测失败
        /// </summary>
        [XmlElement("certify_state")]
        public string CertifyState { get; set; }

        /// <summary>
        /// 人脸认证元数据信息
        /// </summary>
        [XmlElement("meta_info")]
        public OpenCertifyMetaInfo MetaInfo { get; set; }

        /// <summary>
        /// 人脸图片质量分，单位为分
        /// </summary>
        [XmlElement("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// 人脸比对分，单位分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }
    }
}
