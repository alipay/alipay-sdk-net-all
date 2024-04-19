using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoNameCheckResponse.
    /// </summary>
    public class AlipayOpenMiniBaseinfoNameCheckResponse : AopResponse
    {
        /// <summary>
        /// 校验结果code
        /// </summary>
        [XmlElement("check_code")]
        public string CheckCode { get; set; }

        /// <summary>
        /// 名称校验结果详细说明
        /// </summary>
        [XmlElement("check_memo")]
        public string CheckMemo { get; set; }
    }
}
