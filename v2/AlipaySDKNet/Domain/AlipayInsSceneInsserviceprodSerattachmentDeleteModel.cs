using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneInsserviceprodSerattachmentDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneInsserviceprodSerattachmentDeleteModel : AopObject
    {
        /// <summary>
        /// 待撤回的文件编号 （本字段也就是上传附件接口返回的那个附件ID）
        /// </summary>
        [XmlElement("attachment_no")]
        public string AttachmentNo { get; set; }
    }
}
