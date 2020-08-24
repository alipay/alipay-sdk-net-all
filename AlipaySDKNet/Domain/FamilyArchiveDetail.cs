using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FamilyArchiveDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FamilyArchiveDetail : AopObject
    {
        /// <summary>
        /// 家庭档案中用户填写的详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 家人档案ID
        /// </summary>
        [XmlElement("archive_id")]
        public string ArchiveId { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的区县名称
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的市名称
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 脱敏的家人支付宝登录号
        /// </summary>
        [XmlElement("desensitized_logon_id")]
        public string DesensitizedLogonId { get; set; }

        /// <summary>
        /// 脱敏的家人真实姓名
        /// </summary>
        [XmlElement("desensitized_real_name")]
        public string DesensitizedRealName { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的邮箱地址
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的性别（F：女性；M：男性）
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的职业
        /// </summary>
        [XmlElement("profession")]
        public string Profession { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的省份名称
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 家庭用户档案中填写的真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的家庭角色名称
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 家庭档案中用户填写的邮政编码
        /// </summary>
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
