using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniIcpApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniIcpApplyModel : AopObject
    {
        /// <summary>
        /// 小程序备案小程序信息
        /// </summary>
        [XmlElement("icp_applets")]
        public IcpAppletsInfo IcpApplets { get; set; }

        /// <summary>
        /// 小程序备案小程序负责人信息
        /// </summary>
        [XmlElement("icp_applets_principal_info")]
        public IcpAppletsPrincipalInfo IcpAppletsPrincipalInfo { get; set; }

        /// <summary>
        /// 小程序备案主体信息
        /// </summary>
        [XmlElement("icp_subject")]
        public IcpSubjectInfo IcpSubject { get; set; }
    }
}
