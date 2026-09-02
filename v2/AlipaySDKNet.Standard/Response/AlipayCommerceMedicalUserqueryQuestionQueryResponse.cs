using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalUserqueryQuestionQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalUserqueryQuestionQueryResponse : AopResponse
    {
        /// <summary>
        /// 跳转阿福的上报数据
        /// </summary>
        [XmlElement("feed_back")]
        public string FeedBack { get; set; }

        /// <summary>
        /// 跳转到阿福APP的跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 跳转阿福APP承接的大模型query词
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// query词supId，spm埋点使用
        /// </summary>
        [XmlElement("sup_id")]
        public string SupId { get; set; }
    }
}
