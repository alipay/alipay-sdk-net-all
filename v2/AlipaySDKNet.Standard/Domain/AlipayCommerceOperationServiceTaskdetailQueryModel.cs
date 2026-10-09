using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationServiceTaskdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationServiceTaskdetailQueryModel : AopObject
    {
        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 业务信息查询辅助字段，是个JSON 序列化后字符串，可传入分页信息和门店信息等。当query_type=EARN_DETAIL/LAUNCH_DETAIL/SHOP_EFFECT，示例：{   "pageNum": 1,   "pageSize": 20 }，也可以不传分页，pageNum默认1，pageSize默认 20，最大 100。如果query_type=SHOP_EFFECT，示例：{   "pageNum": 1,   "pageSize": 20,   "shopId": "12345" }。其他query_type，可传空{}
        /// </summary>
        [XmlElement("request_data")]
        public string RequestData { get; set; }

        /// <summary>
        /// 服务code，如流量币服务ALIPAY_LLB
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
