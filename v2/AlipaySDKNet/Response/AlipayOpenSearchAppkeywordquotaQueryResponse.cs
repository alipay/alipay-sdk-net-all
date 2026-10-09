using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchAppkeywordquotaQueryResponse.
    /// </summary>
    public class AlipayOpenSearchAppkeywordquotaQueryResponse : AopResponse
    {
        /// <summary>
        /// 剩余可配置额度数量，返回具体数字
        /// </summary>
        [XmlElement("quota_num")]
        public string QuotaNum { get; set; }
    }
}
