using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatAnswerStopModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAichatAnswerStopModel : AopObject
    {
        /// <summary>
        /// 请求唯一标识，该字段由问答接口返回
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 该字段唯一标识一个问答机器人服务，并在向问答机器人注册服务时候生成给到客户端使用。
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
