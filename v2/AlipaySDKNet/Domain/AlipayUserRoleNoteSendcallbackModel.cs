using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserRoleNoteSendcallbackModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserRoleNoteSendcallbackModel : AopObject
    {
        /// <summary>
        /// 笔记类型
        /// </summary>
        [XmlElement("note_callback_type")]
        public string NoteCallbackType { get; set; }

        /// <summary>
        /// 笔记明细数据
        /// </summary>
        [XmlElement("note_detail")]
        public string NoteDetail { get; set; }

        /// <summary>
        /// 请求参数
        /// </summary>
        [XmlElement("note_req_params")]
        public string NoteReqParams { get; set; }

        /// <summary>
        /// 采集任务
        /// </summary>
        [XmlElement("note_task_id")]
        public string NoteTaskId { get; set; }
    }
}
