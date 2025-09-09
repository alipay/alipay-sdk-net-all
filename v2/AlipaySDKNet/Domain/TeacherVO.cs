using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TeacherVO Data Structure.
    /// </summary>
    [Serializable]
    public class TeacherVO : AopObject
    {
        /// <summary>
        /// 教师简介
        /// </summary>
        [XmlElement("teacher_introduce")]
        public string TeacherIntroduce { get; set; }

        /// <summary>
        /// 教师名称
        /// </summary>
        [XmlElement("teacher_name")]
        public string TeacherName { get; set; }

        /// <summary>
        /// 调用<a href="https://opendocs.alipay.com/mini/3fade898_alipay.marketing.image.enhance.upload?pathHash=a941a783" target="_blank">alipay.marketing.image.enhance.upload</a>，商品联系人头像场景(upload_scene): ITEM_HEAD_SCULPTURE_IMAGE; 尺寸要求:72*72px;
        /// </summary>
        [XmlElement("teacher_picture")]
        public string TeacherPicture { get; set; }
    }
}
