using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalBidataBlockinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalBidataBlockinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 驾驶舱上不同区域的返回数据.
        /// </summary>
        [XmlElement("block_content")]
        public string BlockContent { get; set; }

        /// <summary>
        /// 驾驶舱上不同区域的型，可选值如下："basic_info","trends","hot_words","channel_users","provide_service"
        /// </summary>
        [XmlElement("block_type")]
        public string BlockType { get; set; }
    }
}
