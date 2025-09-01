using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpDataproductFourelementMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpDataproductFourelementMatchModel : AopObject
    {
        /// <summary>
        /// 企业统一社会信用代码
        /// </summary>
        [XmlElement("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ent_name")]
        public string EntName { get; set; }

        /// <summary>
        /// 法人证件号
        /// </summary>
        [XmlElement("fr_cert_no")]
        public string FrCertNo { get; set; }

        /// <summary>
        /// 法人证件号md5值
        /// </summary>
        [XmlElement("fr_cert_no_md_5")]
        public string FrCertNoMd5 { get; set; }

        /// <summary>
        /// 法人证件号（身份证号含护照等其他证件）SHA256加密的密文
        /// </summary>
        [XmlElement("fr_cert_no_sha_256")]
        public string FrCertNoSha256 { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("fr_name")]
        public string FrName { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 企业注册号
        /// </summary>
        [XmlElement("reg_no")]
        public string RegNo { get; set; }
    }
}
