using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsWhiteBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsWhiteBatchqueryModel : AopObject
    {
        /// <summary>
        /// 部门编码
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 学校组织code
        /// </summary>
        [XmlElement("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 页码，不传默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，不传默认为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 白名单类型
        /// </summary>
        [XmlElement("white_type")]
        public string WhiteType { get; set; }
    }
}
