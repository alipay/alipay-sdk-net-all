using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetGroupbudgetApplyResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetGroupbudgetApplyResponse : AopResponse
    {
        /// <summary>
        /// 申请结果，如果成功，返回集团预算编码集合
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("string")]
        public List<string> ResultData { get; set; }

        /// <summary>
        /// 报错信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
