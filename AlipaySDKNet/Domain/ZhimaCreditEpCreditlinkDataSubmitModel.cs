using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkDataSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpCreditlinkDataSubmitModel : AopObject
    {
        /// <summary>
        /// JSON字符串。征信数据提交内容，具体格式由data_type决定。
        /// </summary>
        [XmlElement("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 信用链接数据类型
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商户订单号。即商户授权申请接口所使用的单号
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 请求流水号。保证单场景全局唯一
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
