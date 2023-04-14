using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaOpenKaifangKaifangQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenKaifangKaifangQueryModel : AopObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 多福多寿 的
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }
    }
}
