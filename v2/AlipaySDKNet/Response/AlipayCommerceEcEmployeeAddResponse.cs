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
        /// 企业码生成的员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工开通IOT企业刷脸付的唯一流水号
        /// </summary>
        [XmlElement("iot_unique_id")]
        public string IotUniqueId { get; set; }

        /// <summary>
        /// 员工签约激活吱口令
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
