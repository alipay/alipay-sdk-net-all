using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignUserInfoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignUserInfoRequest : AopObject
    {
        /// <summary>
        /// 授权签署方证件号码
        /// </summary>
        [XmlElement("auth_signer_cert_number")]
        public string AuthSignerCertNumber { get; set; }

        /// <summary>
        /// 授权签署时的签署人证件类型
        /// </summary>
        [XmlElement("auth_signer_cert_type")]
        public string AuthSignerCertType { get; set; }

        /// <summary>
        /// 签署方名称
        /// </summary>
        [XmlElement("auth_signer_name")]
        public string AuthSignerName { get; set; }

        /// <summary>
        /// 是否指定授权人签署,1为true，0为false
        /// </summary>
        [XmlElement("authorized")]
        public string Authorized { get; set; }

        /// <summary>
        /// ture为需要自动签署，false为手动签署
        /// </summary>
        [XmlElement("auto_sign")]
        public bool AutoSign { get; set; }

        /// <summary>
        /// 签署文件列表（包含印模和签署区域）
        /// </summary>
        [XmlArray("ca_system_sign_file_request_list")]
        [XmlArrayItem("ca_system_sign_file_request")]
        public List<CaSystemSignFileRequest> CaSystemSignFileRequestList { get; set; }

        /// <summary>
        /// 邮箱联系方式
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 手机号，用于发送签署短信
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 签署顺序，默认-1无签署顺序
        /// </summary>
        [XmlElement("order")]
        public string Order { get; set; }

        /// <summary>
        /// 是否为我方公司,true：我方公司自动完成签署，不发送短信邮件等 false：需要传递mobile和email
        /// </summary>
        [XmlElement("our_corp")]
        public bool OurCorp { get; set; }

        /// <summary>
        /// true为需要发送链接，false为不需要发送链接
        /// </summary>
        [XmlElement("send_link_flag")]
        public bool SendLinkFlag { get; set; }

        /// <summary>
        /// signUserType为org时必选  企业子类型      * BUS("BUS", "企业"),      * SINGLE("SINGLE", "个体工商户"),      * GOV("GOV", "党政机关"),      * INST("INST", "事业单位"),      * COMMON("COMMON", "社会组织"),      * OTHER("OTHER", "其他组织");
        /// </summary>
        [XmlElement("sign_sub_type")]
        public string SignSubType { get; set; }

        /// <summary>
        /// 签署方用户ID,由签署中心注册生成，不要随便传值，否则无法颁发正确的ca证书
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 个人:PERSON  机构:ORG
        /// </summary>
        [XmlElement("sign_user_type")]
        public string SignUserType { get; set; }

        /// <summary>
        /// 签署方证件号码： 个人传递身份证件号 企业传递统一社会信用编码
        /// </summary>
        [XmlElement("signer_cert_number")]
        public string SignerCertNumber { get; set; }

        /// <summary>
        /// 签署方证件类型 CRED_PSN_CH_IDCARD(大陆身份证) CRED_ORG_USCC(统一社会信用代码)
        /// </summary>
        [XmlElement("signer_cert_type")]
        public string SignerCertType { get; set; }

        /// <summary>
        /// 个人传真实姓名：张三 机构传机构正确的名称：xxx责任有限公司
        /// </summary>
        [XmlElement("signer_name")]
        public string SignerName { get; set; }
    }
}
