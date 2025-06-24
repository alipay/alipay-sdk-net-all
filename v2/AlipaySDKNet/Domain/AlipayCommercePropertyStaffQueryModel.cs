using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyStaffQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyStaffQueryModel : AopObject
    {
        /// <summary>
        /// 姓名 精确匹配
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 手机号 精确匹配
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 员工id 精确匹配
        /// </summary>
        [XmlElement("staff_id")]
        public string StaffId { get; set; }

        /// <summary>
        /// 工号 精确匹配
        /// </summary>
        [XmlElement("staff_no")]
        public string StaffNo { get; set; }
    }
}
