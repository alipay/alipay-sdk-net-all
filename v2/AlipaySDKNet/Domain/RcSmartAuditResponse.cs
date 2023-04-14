using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcSmartAuditResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RcSmartAuditResponse : AopObject
    {
        /// <summary>
        /// 解语花风险内容结果
        /// </summary>
        [XmlElement("data")]
        public ContentAuditResult Data { get; set; }

        /// <summary>
        /// 返回的提示信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 32 返回的结果编码。枚举 SUCCESS：成功 INTERNAL_ERROR：服务异常
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
