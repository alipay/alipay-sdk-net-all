using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAdminLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpAdminLicenseInfo : AopObject
    {
        /// <summary>
        /// 当事人
        /// </summary>
        [XmlElement("dsr")]
        public string Dsr { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 许可表格
        /// </summary>
        [XmlElement("xkbg")]
        public EpAdminLicensePermissionTableInfo Xkbg { get; set; }

        /// <summary>
        /// 许可机关
        /// </summary>
        [XmlElement("xkjg")]
        public string Xkjg { get; set; }

        /// <summary>
        /// 许可内容
        /// </summary>
        [XmlElement("xknr")]
        public string Xknr { get; set; }

        /// <summary>
        /// 许可事项名称
        /// </summary>
        [XmlElement("xksxmc")]
        public string Xksxmc { get; set; }
    }
}
