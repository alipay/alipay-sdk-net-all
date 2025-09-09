using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoCloudpromoAichatEvaluateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoCloudpromoAichatEvaluateModel : AopObject
    {
        /// <summary>
        /// 用于记录用户对问答内容反馈的具体评论
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 表示用户对问答的评价等级
        /// </summary>
        [XmlElement("rating")]
        public string Rating { get; set; }

        /// <summary>
        /// 请求唯一标识，该字段由问答接口返回
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 标识某个bot，该字段由和客户约定产生。
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
