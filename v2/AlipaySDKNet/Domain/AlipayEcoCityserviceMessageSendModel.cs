using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceMessageSendModel : AopObject
    {
        /// <summary>
        /// 消息条数，默认1，需和msg_list数组中消息实际条数保持一致，上限1000条
        /// </summary>
        [XmlElement("batch_size")]
        public long BatchSize { get; set; }

        /// <summary>
        /// 敏感字段加密类型，目前支持md5,sm3; 值为md5时，certificate_number需传入md5值，certificate_username传入未加密值 值为sm3时，certificate_number+certificate_username均需传入sm3加密后值
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 消息列表
        /// </summary>
        [XmlArray("msg_list")]
        [XmlArrayItem("alipay_eco_message_entity")]
        public List<AlipayEcoMessageEntity> MsgList { get; set; }
    }
}
