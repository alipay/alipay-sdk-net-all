using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcLabelEmployeeidlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcLabelEmployeeidlistQueryModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
