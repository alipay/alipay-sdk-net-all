using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServiceQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceQueryResponse : AopResponse
    {
        /// <summary>
        /// 驳回理由
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务描述xml格式
        /// </summary>
        [XmlElement("service_xml")]
        public string ServiceXml { get; set; }

        /// <summary>
        /// 服务状态，EDITING(编辑中)/AUDITING(审核中)/AUDIT_REJECT(审核驳回)/PROMOTION(可推广)/STOP_PROMOTION(停止推广)/INVALID(失效)/PUNISHED(处罚)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 服务模板类型
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }

        /// <summary>
        /// 服务履约类型
        /// </summary>
        [XmlElement("user_service_delivery_type")]
        public string UserServiceDeliveryType { get; set; }
    }
}
