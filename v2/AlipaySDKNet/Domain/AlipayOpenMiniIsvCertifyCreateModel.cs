using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniIsvCertifyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniIsvCertifyCreateModel : AopObject
    {
        /// <summary>
        /// 商家登录支付宝的邮箱帐号或手机号。（1）默认只支持企业账号类型；（2）将is_individual设置为true，支持个体工商户类型的账号（同时也兼容企业账号）（3）将is_individual设置为true且上传营业执照照片，将同时对具备个体工商户营业执照的商家个人账号认证成为个体工商户账号（同时也兼容企业账号、个体工商户账号）
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 营业执照企业名称，如果是“无主体名称个体工商户”则填“个体户+法人姓名”，例如“个体户张三”
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
        /// 默认为 false。当设置为 true 时，支持个体工商户的账号类型（同时兼容企业账号）
        /// </summary>
        [XmlElement("is_individual")]
        public bool IsIndividual { get; set; }

        /// <summary>
        /// 商家法人名称
        /// </summary>
        [XmlElement("legal_personal_name")]
        public string LegalPersonalName { get; set; }

        /// <summary>
        /// 营业执照图片的Base64编码字符串，图片大小不能超过2M。将is_individual设置为true，当传入该参数后，如果商家账号不是个体工商户类型，将同时为商家升级账号，无需商家额外操作升级（同时支持企业账号、个体工商户账号）
        /// </summary>
        [XmlElement("license_pic")]
        public string LicensePic { get; set; }

        /// <summary>
        /// 试用小程序订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
