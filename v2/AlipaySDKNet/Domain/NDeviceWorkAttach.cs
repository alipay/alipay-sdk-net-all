using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeviceWorkAttach Data Structure.
    /// </summary>
    [Serializable]
    public class NDeviceWorkAttach : AopObject
    {
        /// <summary>
        /// 作业附件名称
        /// </summary>
        [XmlElement("attachment_name")]
        public string AttachmentName { get; set; }

        /// <summary>
        /// 用来描述当前上传附件的所属场景
        /// </summary>
        [XmlElement("attachment_scene")]
        public string AttachmentScene { get; set; }

        /// <summary>
        /// 作业记录上传附件类型
        /// </summary>
        [XmlElement("attachment_type")]
        public string AttachmentType { get; set; }

        /// <summary>
        /// 需通过ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id
        /// </summary>
        [XmlElement("attachment_url")]
        public string AttachmentUrl { get; set; }
    }
}
