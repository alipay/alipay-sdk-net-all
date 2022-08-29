using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcsmartApproveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcservcenterRcsmartApproveModel : AopObject
    {
        /// <summary>
        /// 调用系统信息
        /// </summary>
        [XmlElement("app_info")]
        public RcsmartCommonAppInfo AppInfo { get; set; }

        /// <summary>
        /// 素材内容请求信息
        /// </summary>
        [XmlElement("commercialization_approval_req")]
        public RcsmartCommonApprovalReq CommercializationApprovalReq { get; set; }
    }
}
