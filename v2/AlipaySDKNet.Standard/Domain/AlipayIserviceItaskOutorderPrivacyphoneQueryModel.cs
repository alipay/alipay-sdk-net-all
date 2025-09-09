using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceItaskOutorderPrivacyphoneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceItaskOutorderPrivacyphoneQueryModel : AopObject
    {
        /// <summary>
        /// 机构侧工单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 蚂蚁侧工单号
        /// </summary>
        [XmlElement("self_order_id")]
        public string SelfOrderId { get; set; }
    }
}
