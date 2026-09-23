using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationServiceDigitalshopBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceOperationServiceDigitalshopBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 请求结果，是个JSON 序列化后字符串。当请求类型query_type是SHOP_MATCH时，格式为：{"matchResultList":[{"subjectId":"2088xx0000000001","channelType":"SG","matched":1},{"subjectId":"2088xx0000000002","channelType":"GD","matched":0}]}，其中subjectId是smid或pid，channelType填GD（高德）或SG（闪购）,mathed为1时，表示匹配，为0时表示不匹配。
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }

        /// <summary>
        /// 服务code，如数字化门店ALIPAY_DIGITALSHOP
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
