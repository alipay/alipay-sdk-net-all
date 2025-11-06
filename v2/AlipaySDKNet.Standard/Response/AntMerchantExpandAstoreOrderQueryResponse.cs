using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAstoreOrderQueryResponse.
    /// </summary>
    public class AntMerchantExpandAstoreOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("a_store_id")]
        public string AStoreId { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
