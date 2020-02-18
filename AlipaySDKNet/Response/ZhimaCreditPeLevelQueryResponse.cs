using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeLevelQueryResponse.
    /// </summary>
    public class ZhimaCreditPeLevelQueryResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户的芝麻分分级编码。分值范围[A,B,C,D,E]。如果用户数据不足，无法评分时，返回字符串"N/A"。
        /// </summary>
        [XmlElement("level_code")]
        public string LevelCode { get; set; }

        /// <summary>
        /// 用户的芝麻分分级描述。分值范围[信用极好，信用优秀，信用良好，信用中等，信用较差]。如果用户数据不足，无法评分时，返回字符串"N/A"。
        /// </summary>
        [XmlElement("level_name")]
        public string LevelName { get; set; }
    }
}
