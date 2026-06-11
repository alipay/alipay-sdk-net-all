using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FulfillmentStaffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FulfillmentStaffInfo : AopObject
    {
        /// <summary>
        /// 所属部门
        /// </summary>
        [XmlElement("department")]
        public string Department { get; set; }

        /// <summary>
        /// 所属机构/医院
        /// </summary>
        [XmlElement("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// 脱敏显示：139****5678
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 累计服务单数
        /// </summary>
        [XmlElement("service_count")]
        public long ServiceCount { get; set; }

        /// <summary>
        /// 陪诊员姓名
        /// </summary>
        [XmlElement("staff_name")]
        public string StaffName { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 工作年限
        /// </summary>
        [XmlElement("work_years")]
        public long WorkYears { get; set; }

        /// <summary>
        /// 工作年限
        /// </summary>
        [XmlElement("work_years_text")]
        public string WorkYearsText { get; set; }
    }
}
