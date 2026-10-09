using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomizeSyncDataResult Data Structure.
    /// </summary>
    [Serializable]
    public class CustomizeSyncDataResult : AopObject
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 结果状态
        /// </summary>
        [XmlElement("result_status")]
        public string ResultStatus { get; set; }

        /// <summary>
        /// 同步状态
        /// </summary>
        [XmlElement("sync_status")]
        public string SyncStatus { get; set; }
    }
}
