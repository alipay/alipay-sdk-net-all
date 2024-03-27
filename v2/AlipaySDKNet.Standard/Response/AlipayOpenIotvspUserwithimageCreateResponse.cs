using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspUserwithimageCreateResponse.
    /// </summary>
    public class AlipayOpenIotvspUserwithimageCreateResponse : AopResponse
    {
        /// <summary>
        /// 相似脸vid
        /// </summary>
        [XmlElement("similar_vid")]
        public string SimilarVid { get; set; }

        /// <summary>
        /// 增加相似脸vid列表
        /// </summary>
        [XmlArray("similar_vid_list")]
        [XmlArrayItem("string")]
        public List<string> SimilarVidList { get; set; }

        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [XmlElement("vid")]
        public string Vid { get; set; }
    }
}
