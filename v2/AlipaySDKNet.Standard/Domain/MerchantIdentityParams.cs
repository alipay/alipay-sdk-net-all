using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIdentityParams Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIdentityParams : AopObject
    {
        /// <summary>
        /// 证件号码，必填，填写需要验证的证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，必填，当前支持身份证，必须传入IDENTITY_CARD
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 商户支付宝收款账号
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 商户收款账号类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 收款账号真实姓名，必填，填写需要验证的真实姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 间连场景填写商户收单smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 间联商户smid进件的sourcePid。如果该字段非空，优先以该字段做smid的水平鉴权；如果该字段为空，则以接口调用方PID做smid的水平鉴权。
        /// </summary>
        [XmlElement("smid_source_pid")]
        public string SmidSourcePid { get; set; }
    }
}
