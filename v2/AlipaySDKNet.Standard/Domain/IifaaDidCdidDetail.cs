using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IifaaDidCdidDetail Data Structure.
    /// </summary>
    [Serializable]
    public class IifaaDidCdidDetail : AopObject
    {
        /// <summary>
        /// 通知内容代码，保留字段
        /// </summary>
        [XmlElement("alter_code")]
        public string AlterCode { get; set; }

        /// <summary>
        /// 公安一所签发的用户唯一标识
        /// </summary>
        [XmlElement("cdid")]
        public string Cdid { get; set; }

        /// <summary>
        /// 凭证PDF文件和用户二要素hash值的签名内容
        /// </summary>
        [XmlElement("cert_sign")]
        public string CertSign { get; set; }

        /// <summary>
        /// VC唯一id
        /// </summary>
        [XmlElement("vc_id")]
        public string VcId { get; set; }
    }
}
