using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntSignUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AntSignUserInfo : AopObject
    {
        /// <summary>
        /// 是否自动签署
        /// </summary>
        [XmlElement("auto_sign")]
        public bool AutoSign { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("ca_system_sign_file_list")]
        [XmlArrayItem("ca_system_sign_file")]
        public List<CaSystemSignFile> CaSystemSignFileList { get; set; }

        /// <summary>
        /// 签署顺序（默认-1：不指定签署顺序，若指定签署顺序，则依次1<2<3<4 排列）
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 是否为我方公司（我方公司指蚂蚁域公司涵网商银行、重庆消金）
        /// </summary>
        [XmlElement("our_corp")]
        public bool OurCorp { get; set; }

        /// <summary>
        /// 签署完成后的重定向链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 用户类型 个人 PERSON 机构 ORG
        /// </summary>
        [XmlElement("sign_user_type")]
        public string SignUserType { get; set; }

        /// <summary>
        /// 签署方证件号码
        /// </summary>
        [XmlElement("signer_cert_number")]
        public string SignerCertNumber { get; set; }

        /// <summary>
        /// 签署人证件类型
        /// </summary>
        [XmlElement("signer_cert_type")]
        public string SignerCertType { get; set; }

        /// <summary>
        /// 签署方名称
        /// </summary>
        [XmlElement("signer_name")]
        public string SignerName { get; set; }

        /// <summary>
        /// 签署方名称样式
        /// </summary>
        [XmlElement("signer_name_style")]
        public string SignerNameStyle { get; set; }

        /// <summary>
        /// 用户认证信息
        /// </summary>
        [XmlElement("user_certify_info")]
        public UserCertifyInfo UserCertifyInfo { get; set; }
    }
}
