using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerServiceInfo : AopObject
    {
        /// <summary>
        /// 客服工号
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 客服工作手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 客服姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
