using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEmployeeAddResponse.
    /// </summary>
    public class AlipayCommerceEcEmployeeAddResponse : AopResponse
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 资金代付签约链接 1.员工未绑支付宝，拉起员工绑定页面 2.员工已绑支付宝，拉起资金签约页面
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
