using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementExecutetimeModifyResponse.
    /// </summary>
    public class AlipayUserAgreementExecutetimeModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回修改后的执行时间。单位：天。
        /// </summary>
        [XmlElement("execute_time")]
        public string ExecuteTime { get; set; }
    }
}
