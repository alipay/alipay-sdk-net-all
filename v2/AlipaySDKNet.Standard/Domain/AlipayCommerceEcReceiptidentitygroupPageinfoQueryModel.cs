using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcReceiptidentitygroupPageinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcReceiptidentitygroupPageinfoQueryModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小，单位：条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
