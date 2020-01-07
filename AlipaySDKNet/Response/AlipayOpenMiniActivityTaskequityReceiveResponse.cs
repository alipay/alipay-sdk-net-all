using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniActivityTaskequityReceiveResponse.
    /// </summary>
    public class AlipayOpenMiniActivityTaskequityReceiveResponse : AopResponse
    {
        /// <summary>
        /// 状态码，返回SUCCESS时表示正常，其他值时表示异常情况
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 状态信息，正常时为"成功"，异常情况时表示相应的错误信息
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// biz_code不为SUCCESS时，是否可短期内重试
        /// </summary>
        [XmlElement("retryable")]
        public bool Retryable { get; set; }
    }
}
