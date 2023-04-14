using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAuthenticationConsistencyCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthenticationConsistencyCheckModel : AopObject
    {
        /// <summary>
        /// 【证件类型】0:身份证 1:护照 2:军官证 3:士兵证 4:回乡证 5:临时身份证 6:户口簿 7:警官证 8:台胞证 9:营业执照10:其它证件 11:港澳居民来往内地通行证 12:台湾居民来往大陆通行证 13:台湾居民居住证 14:港澳居民居住证 15:港澳身份证 16:外国人永久居住证。注意：用户类型为企业或公司用户时可以不填本字段
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// Md5加密的证件信息，个人用户为加密的证件号码，企业类型为加密的统一信用代码
        /// </summary>
        [XmlElement("encrypt_code")]
        public string EncryptCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户类型（1/2） 1代表公司账户2代表个人账户
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
