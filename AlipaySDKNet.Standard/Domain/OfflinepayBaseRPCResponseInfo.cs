using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflinepayBaseRPCResponseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OfflinepayBaseRPCResponseInfo : AopObject
    {
        /// <summary>
        /// 错误指示器
        /// </summary>
        [XmlElement("error_indicator")]
        public OfflinepayErrorIndicator ErrorIndicator { get; set; }

        /// <summary>
        /// 应答扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }

        /// <summary>
        /// 服务端时间
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }
    }
}
