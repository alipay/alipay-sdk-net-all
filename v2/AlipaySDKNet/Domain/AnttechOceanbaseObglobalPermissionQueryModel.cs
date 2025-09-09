using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalPermissionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalPermissionQueryModel : AopObject
    {
        /// <summary>
        /// 权限码
        /// </summary>
        [XmlElement("permission_code")]
        public string PermissionCode { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
