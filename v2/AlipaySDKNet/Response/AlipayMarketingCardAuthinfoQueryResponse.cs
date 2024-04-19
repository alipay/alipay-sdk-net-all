using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCardAuthinfoQueryResponse.
    /// </summary>
    public class AlipayMarketingCardAuthinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 【证件号码】结合证件类型使用.
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 【证件类型】0:身份证 1:护照 2:军官证 3:士兵证 4:回乡证 5:临时身份证 6:户口簿 7:警官证 8:台胞证 9:营业执照10:其它证件 11:港澳居民来往内地通行证 12:台湾居民来往大陆通行证 13:台湾居民居住证 14:港澳居民居住证 15:港澳身份证 16:外国人永久居住证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 市名称。
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 优先获取email登录名，如果不存在，则返回mobile登录名
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 性别。枚举值如下： F：女性； M：男性。
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 是否是学生
        /// </summary>
        [XmlElement("is_student_certified")]
        public string IsStudentCertified { get; set; }

        /// <summary>
        /// 支付宝会员等级 primary,普通; golden,黄金; platinum,铂金; diamond,钻石unknown,未知。
        /// </summary>
        [XmlElement("member_grade")]
        public string MemberGrade { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 个人用户生日。
        /// </summary>
        [XmlElement("person_birthday")]
        public string PersonBirthday { get; set; }

        /// <summary>
        /// 生日。不包含具体年份，格式MMdd
        /// </summary>
        [XmlElement("person_birthday_without_year")]
        public string PersonBirthdayWithoutYear { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
