using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateObjects Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateObjects : AopObject
    {
        /// <summary>
        /// 若证书类型为资格证书，则必要 中华人民共和国文化和旅游部
        /// </summary>
        [XmlElement("authority")]
        public string Authority { get; set; }

        /// <summary>
        /// 证书Id
        /// </summary>
        [XmlElement("certificate_code")]
        public string CertificateCode { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 证书对应工种
        /// </summary>
        [XmlElement("profession")]
        public string Profession { get; set; }

        /// <summary>
        /// 证书类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
