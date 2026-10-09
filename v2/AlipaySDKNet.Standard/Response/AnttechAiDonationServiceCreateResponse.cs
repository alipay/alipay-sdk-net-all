using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiDonationServiceCreateResponse.
    /// </summary>
    public class AnttechAiDonationServiceCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务回执，调用方需要 说明： 如果在提交创建任务的请求参数中传入了biz_receiet，则此处返回对应的biz_receiet
        /// </summary>
        [XmlElement("biz_receipt")]
        public string BizReceipt { get; set; }

        /// <summary>
        /// 捐瓦礼成的URI地址，附带捐瓦ID和Token查询指定捐瓦记录。
        /// </summary>
        [XmlElement("donation_complete_link")]
        public string DonationCompleteLink { get; set; }

        /// <summary>
        /// 捐瓦记录ID，表明该条数据的唯一标识
        /// </summary>
        [XmlElement("donation_id")]
        public string DonationId { get; set; }

        /// <summary>
        /// 创建捐瓦记录对应的请求ID 说明： 如果在提交创建任务的请求参数中传入了request_id，则此处返回对应的request_id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
