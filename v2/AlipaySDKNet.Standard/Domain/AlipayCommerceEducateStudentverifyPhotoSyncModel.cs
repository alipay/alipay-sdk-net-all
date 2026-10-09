using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateStudentverifyPhotoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateStudentverifyPhotoSyncModel : AopObject
    {
        /// <summary>
        /// 宿主小程序 ID
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 学生 ID（省码 2 位 + 全省统一学号）
        /// </summary>
        [XmlElement("out_student_id")]
        public string OutStudentId { get; set; }

        /// <summary>
        /// 注册底片地址AFTS _URL
        /// </summary>
        [XmlElement("photo_url")]
        public string PhotoUrl { get; set; }
    }
}
