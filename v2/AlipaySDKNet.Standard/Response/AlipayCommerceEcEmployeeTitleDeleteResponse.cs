using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeTitleDeleteResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeTitleDeleteResponse : AopResponse
    {
        /// <summary>
        /// 批量处理抬头的错误信息
        /// </summary>
        [XmlElement("ec_employee_title_failed_list")]
        public EcEmployeeTitleFailed EcEmployeeTitleFailedList { get; set; }
    }
}
