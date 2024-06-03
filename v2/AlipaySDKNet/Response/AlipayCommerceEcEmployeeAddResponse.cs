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
        /// IOT开通刷脸支持唯一操作流水号，此处透出用于外部服务商通过该unique_id便捷调用IOT侧接口
        /// </summary>
        [XmlElement("iot_unique_id")]
        public string IotUniqueId { get; set; }

        /// <summary>
        /// 签约吱口令
        /// </summary>
        [XmlElement("share_code")]
        public string ShareCode { get; set; }

        /// <summary>
        /// 资金代付签约链接 1.员工未绑支付宝，拉起员工绑定页面 2.员工已绑支付宝，拉起资金签约页面
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
