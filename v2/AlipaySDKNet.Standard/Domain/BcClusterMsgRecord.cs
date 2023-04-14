using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BcClusterMsgRecord Data Structure.
    /// </summary>
    [Serializable]
    public class BcClusterMsgRecord : AopObject
    {
        /// <summary>
        /// 业务方id，消息发送时可传入，消息列表返回
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 发送消息名称
        /// </summary>
        [XmlElement("msg_name")]
        public string MsgName { get; set; }

        /// <summary>
        /// 发送分组ids；客户群分组id，此id唯一，分组下会管理一系列的客户群
        /// </summary>
        [XmlArray("send_cluster_ids")]
        [XmlArrayItem("string")]
        public List<string> SendClusterIds { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 发送状态；SENDING,SEND_SUCCESS,SEND_FAILED,SEND_PART_FAILED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 发送模板code，可选以下值 TEXT,IMAGE,LINKS,MINIAPP
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
