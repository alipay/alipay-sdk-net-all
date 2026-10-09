using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountZavatarAvatarQueryResponse.
    /// </summary>
    public class AlipayUserAccountZavatarAvatarQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户保存数字形象信息
        /// </summary>
        [XmlElement("cust_avatar_vo")]
        public AvatarVO CustAvatarVo { get; set; }

        /// <summary>
        /// 场景中的默认动画信息
        /// </summary>
        [XmlArray("default_animation_v_os")]
        [XmlArrayItem("avatar_animation_v_o")]
        public List<AvatarAnimationVO> DefaultAnimationVOs { get; set; }

        /// <summary>
        /// 场景的默认布景信息
        /// </summary>
        [XmlArray("default_stage_scenery_v_os")]
        [XmlArrayItem("stage_scenery_v_o")]
        public List<StageSceneryVO> DefaultStageSceneryVOs { get; set; }

        /// <summary>
        /// 用户数字人id
        /// </summary>
        [XmlElement("digital_human_id")]
        public string DigitalHumanId { get; set; }

        /// <summary>
        /// 场景下的默认虚拟形象信息
        /// </summary>
        [XmlArray("init_avatar_v_os")]
        [XmlArrayItem("avatar_v_o")]
        public List<AvatarVO> InitAvatarVOs { get; set; }

        /// <summary>
        /// 返回的形象模型层级
        /// </summary>
        [XmlElement("model_level")]
        public string ModelLevel { get; set; }

        /// <summary>
        /// 场景中可以选择的动画信息
        /// </summary>
        [XmlArray("optional_animation_v_os")]
        [XmlArrayItem("avatar_animation_v_o")]
        public List<AvatarAnimationVO> OptionalAnimationVOs { get; set; }

        /// <summary>
        /// 数字人场景可选布景
        /// </summary>
        [XmlArray("optional_stage_scenery_v_os")]
        [XmlArrayItem("stage_scenery_v_o")]
        public List<StageSceneryVO> OptionalStageSceneryVOs { get; set; }
    }
}
