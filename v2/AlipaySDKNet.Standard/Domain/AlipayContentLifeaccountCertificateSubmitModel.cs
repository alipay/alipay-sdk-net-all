using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLifeaccountCertificateSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLifeaccountCertificateSubmitModel : AopObject
    {
        /// <summary>
        /// 资质证明
        /// </summary>
        [XmlElement("certificate")]
        public CertificateRequest Certificate { get; set; }

        /// <summary>
        /// 加密后的好大夫id，与public id一起指定一个操作用户
        /// </summary>
        [XmlElement("hdf_id_encrypted")]
        public string HdfIdEncrypted { get; set; }

        /// <summary>
        /// 用于指定补充资质信息的内容号
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
