using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceVerificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasFaceVerificationQueryModel : AopObject
    {
        /// <summary>
        /// 填入人脸核身初始化阶段获取到的certify_id
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 是否需要返回活体结果图片，默认为N（不返图）
        /// </summary>
        [XmlElement("need_alive_photo")]
        public string NeedAlivePhoto { get; set; }
    }
}
