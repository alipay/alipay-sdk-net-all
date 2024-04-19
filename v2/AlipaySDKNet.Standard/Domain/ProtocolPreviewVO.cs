using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProtocolPreviewVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProtocolPreviewVO : AopObject
    {
        /// <summary>
        /// 协议内容
        /// </summary>
        [XmlElement("protocol_content")]
        public string ProtocolContent { get; set; }

        /// <summary>
        /// oss文件地址
        /// </summary>
        [XmlElement("protocol_file_path")]
        public string ProtocolFilePath { get; set; }

        /// <summary>
        /// 支付宝商户协议
        /// </summary>
        [XmlElement("protocol_name")]
        public string ProtocolName { get; set; }
    }
}
