using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncAntbudgetGroupbudgetRefundResponse.
    /// </summary>
    public class AlipayBossFncAntbudgetGroupbudgetRefundResponse : AopResponse
    {
        /// <summary>
        /// 释放结果，如果成功，返回集团预算编码集合
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("string")]
        public List<string> ResultData { get; set; }

        /// <summary>
        /// pass/报错信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
