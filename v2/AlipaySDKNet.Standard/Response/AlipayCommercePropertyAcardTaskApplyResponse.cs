using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePropertyAcardTaskApplyResponse.
    /// </summary>
    public class AlipayCommercePropertyAcardTaskApplyResponse : AopResponse
    {
        /// <summary>
        /// 制卡请求受理后的制卡任务唯一ID，与outBizId一一对应
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 制卡请求受理后的制卡任务唯一ID，与out_biz_id一一对应
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
