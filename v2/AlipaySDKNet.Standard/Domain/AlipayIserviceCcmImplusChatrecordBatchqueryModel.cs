using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmImplusChatrecordBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmImplusChatrecordBatchqueryModel : AopObject
    {
        /// <summary>
        /// 传递参数id
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 用于管理用户聊天会话
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 如果为0，则向前拉取消息
        /// </summary>
        [XmlElement("cursor_id")]
        public long CursorId { get; set; }

        /// <summary>
        /// FORWARD-向前 BACK-向后,默认向前
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 不填则拉取完才会结束
        /// </summary>
        [XmlElement("end_id")]
        public long EndId { get; set; }

        /// <summary>
        /// 默认20条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
