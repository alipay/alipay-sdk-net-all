using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRobotSessionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmRobotSessionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 开始时间戳（单位毫秒）
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 结束时间戳（单位毫秒）
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 聊天窗编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 会话用户id
        /// </summary>
        [XmlElement("visitor_id")]
        public string VisitorId { get; set; }
    }
}
