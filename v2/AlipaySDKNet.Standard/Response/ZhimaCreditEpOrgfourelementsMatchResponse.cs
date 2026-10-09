using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpOrgfourelementsMatchResponse.
    /// </summary>
    public class ZhimaCreditEpOrgfourelementsMatchResponse : AopResponse
    {
        /// <summary>
        /// 四要素匹配结果码
        /// </summary>
        [XmlElement("match_code")]
        public string MatchCode { get; set; }

        /// <summary>
        /// 校验结果不匹配列
        /// </summary>
        [XmlArray("match_result_columns")]
        [XmlArrayItem("string")]
        public List<string> MatchResultColumns { get; set; }
    }
}
