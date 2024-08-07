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
        /// IOT开通刷脸唯一流水号，服务商可通过该unique_id便捷调用IOT侧接口
        /// </summary>
        [XmlElement("iot_unique_id")]
        public string IotUniqueId { get; set; }

        /// <summary>
        /// 员工签约吱口令
        /// </summary>
        [XmlElement("share_code")]
        public string ShareCode { get; set; }

        /// <summary>
        /// 员工签约激活页面链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
