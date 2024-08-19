using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsKocshorturlGenerateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsKocshorturlGenerateModel : AopObject
    {
        /// <summary>
        /// 机构标识，由我方为机构分配，用于校验和配置隔离
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 机构对应的保保号id，需在系统中落过记录且绑定机构
        /// </summary>
        [XmlElement("koc_uid")]
        public string KocUid { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 唯一标识|用户请求ID (partnerID|requestID，限制数字、字母，分隔符用竖线"|"；字段长度<50字符)
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
