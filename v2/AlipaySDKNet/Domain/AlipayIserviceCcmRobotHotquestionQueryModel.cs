using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRobotHotquestionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRobotHotquestionQueryModel : AopObject
    {
        /// <summary>
        /// 聊天窗code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
