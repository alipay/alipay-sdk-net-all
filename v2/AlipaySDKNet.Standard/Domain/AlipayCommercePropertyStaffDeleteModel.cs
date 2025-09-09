using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePropertyStaffDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePropertyStaffDeleteModel : AopObject
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("staff_id")]
        public string StaffId { get; set; }
    }
}
