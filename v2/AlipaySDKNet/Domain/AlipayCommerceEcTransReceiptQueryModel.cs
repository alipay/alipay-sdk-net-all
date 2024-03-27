using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTransReceiptQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTransReceiptQueryModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 文件申请号
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
