using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalAqUserinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalAqUserinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 表示当前请求是否有可查询的账户
        /// </summary>
        [XmlElement("has_quick_account")]
        public bool HasQuickAccount { get; set; }

        /// <summary>
        /// 代表当前请求的随机值
        /// </summary>
        [XmlElement("random_key")]
        public string RandomKey { get; set; }
    }
}
