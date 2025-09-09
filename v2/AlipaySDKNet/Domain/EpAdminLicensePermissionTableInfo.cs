using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAdminLicensePermissionTableInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpAdminLicensePermissionTableInfo : AopObject
    {
        /// <summary>
        /// 审批类别
        /// </summary>
        [XmlElement("splb")]
        public string Splb { get; set; }

        /// <summary>
        /// 许可决定日期
        /// </summary>
        [XmlElement("xkjdrq")]
        public string Xkjdrq { get; set; }

        /// <summary>
        /// 许可截止日期
        /// </summary>
        [XmlElement("xkjzrq")]
        public string Xkjzrq { get; set; }

        /// <summary>
        /// 行政许可决定书文号
        /// </summary>
        [XmlElement("xzxujdwh")]
        public string Xzxujdwh { get; set; }
    }
}
