using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCustomerBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCustomerBatchqueryModel : AopObject
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 用户id类型，参考idType
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 分页大小-上限10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 请求唯一ID，用于链路跟踪和问题排查
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }
    }
}
