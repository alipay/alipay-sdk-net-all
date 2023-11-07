using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcDepartmentUpgradeSubmitResponse.
    /// </summary>
    public class AlipayCommerceEcDepartmentUpgradeSubmitResponse : AopResponse
    {
        /// <summary>
        /// 部门提交升级后的工单id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 子企业签约因公付链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
