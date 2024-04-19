using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeStyle Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeStyle : AopObject
    {
        /// <summary>
        /// 查询出的风格id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 查询出对应图片id的路径
        /// </summary>
        [XmlElement("mock_img")]
        public string MockImg { get; set; }

        /// <summary>
        /// 合成图片所需要的模版id
        /// </summary>
        [XmlElement("pic_template_id")]
        public string PicTemplateId { get; set; }
    }
}
