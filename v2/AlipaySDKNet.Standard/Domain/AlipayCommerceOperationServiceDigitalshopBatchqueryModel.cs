using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationServiceDigitalshopBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationServiceDigitalshopBatchqueryModel : AopObject
    {
        /// <summary>
        /// 请求类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 业务信息，是个JSON 序列化后字符串，比如商户信息、门店信息等。 当请求类型query_type是SHOP_MATCH时，格式为：{"matchItemList":[{"subjectId":"2088xx0000000001","channelType":"SG"},{"subjectId":"2088xx0000000002","channelType":"GD"}]}，其中subjectId是smid或pid，channelType填GD（高德）或SG（闪购）一次最多可以传5个id批量查询。
        /// </summary>
        [XmlElement("request_data")]
        public string RequestData { get; set; }

        /// <summary>
        /// 服务code，如数字化门店ALIPAY_DIGITALSHOP
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
