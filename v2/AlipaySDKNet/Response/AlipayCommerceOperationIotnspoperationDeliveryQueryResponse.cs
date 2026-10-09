using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationIotnspoperationDeliveryQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationIotnspoperationDeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 推广计划基础信息
        /// </summary>
        [XmlElement("n_delivery_base_info")]
        public NDeliveryBaseInfo NDeliveryBaseInfo { get; set; }

        /// <summary>
        /// 推广计划创建信息描述
        /// </summary>
        [XmlElement("n_delivery_create_msg")]
        public string NDeliveryCreateMsg { get; set; }

        /// <summary>
        /// 碰一下推广计划id
        /// </summary>
        [XmlElement("n_delivery_id")]
        public string NDeliveryId { get; set; }

        /// <summary>
        /// 推广发放规则配置。
        /// </summary>
        [XmlElement("n_delivery_paly_config")]
        public NDeliveryPalyConfig NDeliveryPalyConfig { get; set; }

        /// <summary>
        /// 推广计划审核信息描述
        /// </summary>
        [XmlElement("n_delivery_reject_msg")]
        public string NDeliveryRejectMsg { get; set; }

        /// <summary>
        /// 碰一下推广计划状态
        /// </summary>
        [XmlElement("n_delivery_status")]
        public string NDeliveryStatus { get; set; }

        /// <summary>
        /// 推广曝光规则
        /// </summary>
        [XmlElement("n_delivery_target_rule")]
        public NDeliveryTargetRule NDeliveryTargetRule { get; set; }
    }
}
