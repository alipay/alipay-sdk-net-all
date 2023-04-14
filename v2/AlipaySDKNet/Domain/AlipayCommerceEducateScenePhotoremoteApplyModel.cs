using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateScenePhotoremoteApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateScenePhotoremoteApplyModel : AopObject
    {
        /// <summary>
        /// 证件编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。{1:居民身份证；A:护照；X:学工号}
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 学生上半身照片的Base64编码。（注：1.图片的格式必须是jpg的；2.图片大小不超过125KB；3.非Data URI格式，请直接返回原文件的base64编码）
        /// </summary>
        [XmlElement("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// 外部照片Id。（注：用于关联当前提交的学生信息。如果同一个学生尝试重新提交，请务必生成新的id）
        /// </summary>
        [XmlElement("out_photo_id")]
        public string OutPhotoId { get; set; }

        /// <summary>
        /// 用户外部ID。（服务商内部唯一ID，唯一关联一位学生/教职工)
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 学生家长支付宝账号绑定的手机号。
        /// </summary>
        [XmlElement("parent_phone_number")]
        public string ParentPhoneNumber { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 学生/教职工/访客姓名
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }
    }
}
