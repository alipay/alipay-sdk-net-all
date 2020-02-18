using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataIotdataSearchlibraryBaiQueryResponse.
    /// </summary>
    public class AlipayDataIotdataSearchlibraryBaiQueryResponse : AopResponse
    {
        /// <summary>
        /// 采用的模型以及版本说明
        /// </summary>
        [XmlElement("model_info")]
        public string ModelInfo { get; set; }

        /// <summary>
        /// 重复列表，json list格式
        /// </summary>
        [XmlElement("repeat_info")]
        public string RepeatInfo { get; set; }

        /// <summary>
        /// 相似度信息列表，json list格式
        /// </summary>
        [XmlElement("similarity_info")]
        public string SimilarityInfo { get; set; }
    }
}
