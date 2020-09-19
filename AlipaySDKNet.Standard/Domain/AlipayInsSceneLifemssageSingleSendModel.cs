using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneLifemssageSingleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneLifemssageSingleSendModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 生活号ID
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 推送模板上下文
        /// </summary>
        [XmlElement("push_context")]
        public string PushContext { get; set; }

        /// <summary>
        /// 模板消息上下文
        /// </summary>
        [XmlElement("template_context")]
        public string TemplateContext { get; set; }

        /// <summary>
        /// 生活号模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 发送到的用户ID
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
