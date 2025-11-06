using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCsfuServicehallSyncResponse.
    /// </summary>
    public class AlipayIserviceCsfuServicehallSyncResponse : AopResponse
    {
        /// <summary>
        /// 对话动作 VobotReActionEnum
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 是否允许打断
        /// </summary>
        [XmlElement("interruptible")]
        public bool Interruptible { get; set; }

        /// <summary>
        /// 机器人说的话
        /// </summary>
        [XmlElement("output_content")]
        public string OutputContent { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 转人工目标码
        /// </summary>
        [XmlElement("transfer_target_code")]
        public string TransferTargetCode { get; set; }
    }
}
