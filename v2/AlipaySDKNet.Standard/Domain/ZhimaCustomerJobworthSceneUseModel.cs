using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthSceneUseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerJobworthSceneUseModel : AopObject
    {
        /// <summary>
        /// 针对不同的场景类型，使用不同的字段
        /// </summary>
        [XmlElement("extra_info")]
        public SceneInfo ExtraInfo { get; set; }

        /// <summary>
        /// 候选人列表
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
