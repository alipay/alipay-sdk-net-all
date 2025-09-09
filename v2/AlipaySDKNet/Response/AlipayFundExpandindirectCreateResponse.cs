using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundExpandindirectCreateResponse.
    /// </summary>
    public class AlipayFundExpandindirectCreateResponse : AopResponse
    {
        /// <summary>
        /// 进件单创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 进件单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部单号（唯一幂等号）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 进件单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 进件单任务完结时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("task_finish_time")]
        public string TaskFinishTime { get; set; }
    }
}
