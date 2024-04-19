using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportVehicleownerMessageSendModel : AopObject
    {
        /// <summary>
        /// 消息条数，需和msg_list数组中消息实际条数保持一致，上限20条
        /// </summary>
        [XmlElement("batch_size")]
        public long BatchSize { get; set; }

        /// <summary>
        /// 敏感字段加密类型，目前支持md5，默认加密字段是msg_list中每条消息的“certificate_number”字段
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 消息列表
        /// </summary>
        [XmlArray("msg_list")]
        [XmlArrayItem("veh_message_entity")]
        public List<VehMessageEntity> MsgList { get; set; }
    }
}
