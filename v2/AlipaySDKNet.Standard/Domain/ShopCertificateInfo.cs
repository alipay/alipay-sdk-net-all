using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCertificateInfo : AopObject
    {
        /// <summary>
        /// 法人证件反面
        /// </summary>
        [XmlElement("legal_back_pic")]
        public string LegalBackPic { get; set; }

        /// <summary>
        /// 证件到期时间
        /// </summary>
        [XmlElement("legal_end_time")]
        public string LegalEndTime { get; set; }

        /// <summary>
        /// 法人证件正面
        /// </summary>
        [XmlElement("legal_front_pic")]
        public string LegalFrontPic { get; set; }

        /// <summary>
        /// 法人证件名称
        /// </summary>
        [XmlElement("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 法人证件号
        /// </summary>
        [XmlElement("legal_no")]
        public string LegalNo { get; set; }
    }
}
