using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneUserUnsignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneUserUnsignModel : AopObject
    {
        /// <summary>
        /// 开通人绑定的支付宝openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝学校内标
        /// </summary>
        [XmlElement("alipay_school_id")]
        public string AlipaySchoolId { get; set; }

        /// <summary>
        /// 开通人绑定的支付宝UID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 学生（教职工）的刷脸openId
        /// </summary>
        [XmlElement("face_open_id")]
        public string FaceOpenId { get; set; }

        /// <summary>
        /// 学生（教职工）的刷脸UID
        /// </summary>
        [XmlElement("face_user_id")]
        public string FaceUserId { get; set; }
    }
}
