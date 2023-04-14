using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreateMiniRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CreateMiniRequest : AopObject
    {
        /// <summary>
        /// 商家登录支付宝的邮箱帐号或手机号，当前仅支持企业支付宝帐号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 营业执照企业名称
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 营业执照编码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 商家联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 商家联系人手机电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 是否支持个人账号升级为个体工商户的账号类型 true为支持
        /// </summary>
        [XmlElement("is_individual")]
        public bool IsIndividual { get; set; }

        /// <summary>
        /// 商家法人名称
        /// </summary>
        [XmlElement("legal_personal_name")]
        public string LegalPersonalName { get; set; }

        /// <summary>
        /// 营业执照图片的Base64编码字符串，图片大小不能超过2M。将is_individual设置为true，当传入该参数后，如果商家账号不是个体工商户类型，将同时为商家升级账号。
        /// </summary>
        [XmlElement("license_pic")]
        public string LicensePic { get; set; }

        /// <summary>
        /// 开发者外部订单号，通过开发者账号+outOrderNo做业务幂等
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
