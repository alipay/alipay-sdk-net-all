using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeIdlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeIdlistQueryModel : AopObject
    {
        /// <summary>
        /// 部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 查询页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页查询大小，限制最大为1000
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
