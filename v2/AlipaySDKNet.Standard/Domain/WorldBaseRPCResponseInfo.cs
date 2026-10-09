using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorldBaseRPCResponseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WorldBaseRPCResponseInfo : AopObject
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_indicator")]
        public WorldErrorIndicator ErrorIndicator { get; set; }

        /// <summary>
        /// 应答扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 服务端时间(long型数据)
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }
    }
}
