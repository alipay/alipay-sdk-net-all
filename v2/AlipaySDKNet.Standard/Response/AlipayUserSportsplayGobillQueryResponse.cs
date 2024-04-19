using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSportsplayGobillQueryResponse.
    /// </summary>
    public class AlipayUserSportsplayGobillQueryResponse : AopResponse
    {
        /// <summary>
        /// Go业务时间 时间戳
        /// </summary>
        [XmlElement("biz_time")]
        public long BizTime { get; set; }

        /// <summary>
        /// 是否完成当前路线
        /// </summary>
        [XmlElement("complete")]
        public bool Complete { get; set; }

        /// <summary>
        /// 当前路线已前进步数
        /// </summary>
        [XmlElement("forward_step_count")]
        public long ForwardStepCount { get; set; }

        /// <summary>
        /// Go流水记录id
        /// </summary>
        [XmlElement("go_bill_id")]
        public string GoBillId { get; set; }

        /// <summary>
        /// Go使用的步数
        /// </summary>
        [XmlElement("go_step_count")]
        public long GoStepCount { get; set; }

        /// <summary>
        /// 路线id
        /// </summary>
        [XmlElement("path_id")]
        public string PathId { get; set; }

        /// <summary>
        /// 路线名称
        /// </summary>
        [XmlElement("path_name")]
        public string PathName { get; set; }

        /// <summary>
        /// 路线参与记录id
        /// </summary>
        [XmlElement("path_record_id")]
        public string PathRecordId { get; set; }
    }
}
