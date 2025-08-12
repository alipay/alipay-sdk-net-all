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
        /// 业务逻辑会针对biz_from来决定：账号属于未认证状态时是否透出错误码和错误文案
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 【证件类型】0:身份证 1:护照 2:军官证 3:士兵证 4:回乡证 5:临时身份证 6:户口簿 7:警官证 8:台胞证 9:营业执照10:其它证件 11:港澳居民来往内地通行证 12:台湾居民来往大陆通行证 13:台湾居民居住证 14:港澳居民居住证 15:港澳身份证 16:外国人永久居住证。注意：用户类型为企业或公司用户时可以不填本字段
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// T: 表示通过营业执照来核验个人账号，仅在user_type为2且cert_type为9时会消费该字段，非必填; F: 传F或者不传，则不支持通过营业执照来核验个人账号； 默认值为F
        /// </summary>
        [XmlElement("check_by_license")]
        public string CheckByLicense { get; set; }

        /// <summary>
        /// Md5加密的证件信息，个人用户为加密的证件号码，企业类型为加密的统一信用代码; 个人用户且证件类型为营业执照时，该字段为加密的统一信用代码
        /// </summary>
        [XmlElement("encrypt_code")]
        public string EncryptCode { get; set; }

        /// <summary>
        /// 当user_type为2，cert_type为9时，即通过营业执照核验个人账号时，该字段必传
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

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
