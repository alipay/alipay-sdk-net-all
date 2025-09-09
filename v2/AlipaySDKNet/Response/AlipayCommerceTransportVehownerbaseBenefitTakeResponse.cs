using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehownerbaseBenefitTakeResponse.
    /// </summary>
    public class AlipayCommerceTransportVehownerbaseBenefitTakeResponse : AopResponse
    {
        /// <summary>
        /// 权益发放组件集
        /// </summary>
        [XmlElement("components")]
        public BenefitActionResponseComponents Components { get; set; }

        /// <summary>
        /// 当前日期
        /// </summary>
        [XmlElement("current_date")]
        public string CurrentDate { get; set; }

        /// <summary>
        /// 方案标识
        /// </summary>
        [XmlElement("operation_param_identity")]
        public string OperationParamIdentity { get; set; }
    }
}
