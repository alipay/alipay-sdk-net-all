using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkCollectCreateResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkCollectCreateResponse : AopResponse
    {
        /// <summary>
        /// 数据内容
        /// </summary>
        [XmlElement("content")]
        public EpCreditLinkCreateQueryDataInfo Content { get; set; }

        /// <summary>
        /// 查询任务创建结果
        /// </summary>
        [XmlElement("data_result")]
        public string DataResult { get; set; }

        /// <summary>
        /// INIT表示任务还在初始化状态，COLLECT表示任务在进行中，END表示任务处理完成，FAIL表示任务处理失败。
        /// </summary>
        [XmlElement("data_status")]
        public string DataStatus { get; set; }

        /// <summary>
        /// 请求数据类型。与传入值一致
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商户单号。与传入值一致
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
