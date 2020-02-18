using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEduCampusJobstudentApplyResponse.
    /// </summary>
    public class AlipayEcoEduCampusJobstudentApplyResponse : AopResponse
    {
        /// <summary>
        /// 备注问题或异常
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 备用字段，JSON格式
        /// </summary>
        [XmlElement("content_var")]
        public string ContentVar { get; set; }

        /// <summary>
        /// 学历
        /// </summary>
        [XmlElement("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 状态码描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 学生入学时间
        /// </summary>
        [XmlElement("enrollment_time")]
        public string EnrollmentTime { get; set; }

        /// <summary>
        /// 是否毕业（1-已毕业；2-未毕业）
        /// </summary>
        [XmlElement("is_graduate")]
        public long IsGraduate { get; set; }

        /// <summary>
        /// 学生是否在趣校园平台认证(1-认证；2-未认证)
        /// </summary>
        [XmlElement("is_student")]
        public long IsStudent { get; set; }

        /// <summary>
        /// 返回code编码;成功返回Success
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 学生所在学校
        /// </summary>
        [XmlElement("school")]
        public string School { get; set; }
    }
}
