using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeAddModel : AopObject
    {
        /// <summary>
        /// 是否需要生成吱口令，默认不生成
        /// </summary>
        [XmlElement("create_share_code")]
        public bool CreateShareCode { get; set; }

        /// <summary>
        /// 员工所属部门
        /// </summary>
        [XmlArray("department_ids")]
        [XmlArrayItem("string")]
        public List<string> DepartmentIds { get; set; }

        /// <summary>
        /// 证件号码，根据employee_cert_type指定的证件类型，传入对应的证件号码，可用于企业人脸库员工刷脸开通时的核验。
        /// </summary>
        [XmlElement("employee_cert_no")]
        public string EmployeeCertNo { get; set; }

        /// <summary>
        /// 证件类型，目前仅支持身份证，可用于企业人脸库员工刷脸开通时的核验
        /// </summary>
        [XmlElement("employee_cert_type")]
        public string EmployeeCertType { get; set; }

        /// <summary>
        /// 员工邮箱
        /// </summary>
        [XmlElement("employee_email")]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工手机号
        /// </summary>
        [XmlElement("employee_mobile")]
        public string EmployeeMobile { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工编号/工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 加密证件号，需与证件类型搭配使用，可替代证件号码(employee_cert_no)字段
        /// </summary>
        [XmlElement("encrypt_cert_no")]
        public string EncryptCertNo { get; set; }

        /// <summary>
        /// 加密手机号，可替代手机号(employee_mobile)字段
        /// </summary>
        [XmlElement("encrypt_mobile")]
        public string EncryptMobile { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 员工身份唯一标识
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 当identity_type为ALIPAY_USER_ID时，此字段传入open_id
        /// </summary>
        [XmlElement("identity_open_id")]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 员工身份类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 员工刷脸加入企业人脸库时的核验方式，签约开通人脸库时必传
        /// </summary>
        [XmlElement("iot_check_type")]
        public string IotCheckType { get; set; }

        /// <summary>
        /// 员工在企业人脸库的人脸唯一标识（该字段已作废，不支持自定义传入） 当前字段已废弃(iot不支持自定义传入)
        /// </summary>
        [XmlElement("iot_vid")]
        public string IotVid { get; set; }

        /// <summary>
        /// 个性化信息 <a href='https://opendocs.alipay.com/pre-open/0ceh47?pathHash=14fac87c'>详见文档</a>
        /// </summary>
        [XmlElement("profiles")]
        public string Profiles { get; set; }

        /// <summary>
        /// 默认角色列表，目前只支持默认为 USER 当前字段已废弃(只有一个可选默认值，没必要传)
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }

        /// <summary>
        /// 员工签约后回跳地址；支持 alipay scheme 协议地址，不传默认跳转企业码小程序首页
        /// </summary>
        [XmlElement("sign_return_url")]
        public string SignReturnUrl { get; set; }

        /// <summary>
        /// 签约链接页面是否需要自动回显员工的身份信息（手机或邮箱），默认不显示
        /// </summary>
        [XmlElement("sign_url_carry_info")]
        public bool SignUrlCarryInfo { get; set; }

        /// <summary>
        /// 代扣签约字符串，需调支付宝个人协议页面签约接口，并按规则生成，见 <a href='https://opendocs.alipay.com/pre-open/20170601105911096277new/moiixx?pathHash=10b1fa66'>参考文档</a> 3.1.3 生成签约字符串示例
        /// </summary>
        [XmlElement("withholding_sign_str")]
        public string WithholdingSignStr { get; set; }
    }
}
