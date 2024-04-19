using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceCaasBlacklistConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceCaasBlacklistConsultModel : AopObject
    {
        /// <summary>
        /// app_name+调用方系统名称；会与分配的app_token做校验
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// app_token+每一个app分配一个
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// biz_code+咨询服务分配的业务code
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// event_code+服务方分配的咨询事件code
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// merchant_pid+商户pid，与组织机构代码不可全部为空
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// org_code+商户组织机构代码； 与Pid不可全部为空
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// request_id+请求方自行生成的请求号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
