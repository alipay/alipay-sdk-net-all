using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetCancelResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetCancelResponse : AopResponse
    {
        /// <summary>
        /// 描述具体的错误信息，方便排查问题
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
