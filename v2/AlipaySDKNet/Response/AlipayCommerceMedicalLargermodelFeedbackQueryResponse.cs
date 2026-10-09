using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalLargermodelFeedbackQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalLargermodelFeedbackQueryResponse : AopResponse
    {
        /// <summary>
        /// 反馈选项数据
        /// </summary>
        [XmlArray("feedback_options_list")]
        [XmlArrayItem("feedback_options_v_o")]
        public List<FeedbackOptionsVO> FeedbackOptionsList { get; set; }
    }
}
