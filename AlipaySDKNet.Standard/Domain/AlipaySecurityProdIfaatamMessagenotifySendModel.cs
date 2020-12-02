using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdIfaatamMessagenotifySendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdIfaatamMessagenotifySendModel : AopObject
    {
        /// <summary>
        /// 业务操作类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// ISV接入的汽车终端(T-box)唯一标示,表明消息是由该终端发出
        /// </summary>
        [XmlElement("box_did")]
        public string BoxDid { get; set; }

        /// <summary>
        /// business_id业务流水号+唯一+用于和ISV厂商服务端唯一确定一笔业务
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 汽车终端发起的消息通知内容,包含车辆的模块,当前的状态,和状态描述信息
        /// </summary>
        [XmlElement("vehicle_message_info")]
        public VehicleMessageInfo VehicleMessageInfo { get; set; }
    }
}
