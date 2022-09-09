using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftUserTemplateBoxInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GiftUserTemplateBoxInfo : AopObject
    {
        /// <summary>
        /// 封面氛围容器，用于拆包页
        /// </summary>
        [XmlElement("atmosphere_box")]
        public GiftTemplateAtmosphereBox AtmosphereBox { get; set; }

        /// <summary>
        /// 封底容器，用于拆红包页
        /// </summary>
        [XmlElement("back_cover_box")]
        public GiftTemplateBackCoverBox BackCoverBox { get; set; }

        /// <summary>
        /// 封面基础信，包含封面名称、祝福语等等
        /// </summary>
        [XmlElement("base_info")]
        public GiftTemplateBaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 封面按钮容器，用于拆红包页
        /// </summary>
        [XmlElement("button_box")]
        public GiftTemplateButtonBox ButtonBox { get; set; }

        /// <summary>
        /// 封面容器，使用于拆红包页与红包详情页
        /// </summary>
        [XmlElement("front_cover_box")]
        public GiftTemplateFrontCoverBox FrontCoverBox { get; set; }

        /// <summary>
        /// 封面故事容器，用于红包详情页
        /// </summary>
        [XmlElement("story_box")]
        public GiftTemplateStoryBox StoryBox { get; set; }

        /// <summary>
        /// 封面是否在有效期内可被领取，true代表在有效期内，false代表不在有效期内
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }

        /// <summary>
        /// 封面的有效期结束时间，is_valid==false时返回，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 封面的有效期开始时间，当is_valid==true时返回，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("valid_start_time")]
        public string ValidStartTime { get; set; }
    }
}
