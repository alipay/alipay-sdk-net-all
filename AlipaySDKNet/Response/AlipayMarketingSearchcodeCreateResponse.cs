using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingSearchcodeCreateResponse.
    /// </summary>
    public class AlipayMarketingSearchcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 搜索码后边拼接的文案
        /// </summary>
        [XmlElement("end_content")]
        public string EndContent { get; set; }

        /// <summary>
        /// box搜索品牌词
        /// </summary>
        [XmlElement("keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// 搜索口令前边拼接文案
        /// </summary>
        [XmlElement("pre_content")]
        public string PreContent { get; set; }

        /// <summary>
        /// 搜索口令值
        /// </summary>
        [XmlElement("search_code")]
        public string SearchCode { get; set; }
    }
}
