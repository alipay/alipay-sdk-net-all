using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InfoSecAnalyzeSyncContent Data Structure.
    /// </summary>
    [Serializable]
    public class InfoSecAnalyzeSyncContent : AopObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 业务过检分类,如果没有勾选分类提交返回参数错误，您可指定多个垃圾类别进行机器检测，多个垃圾类别以逗号分隔（"porn,terrorism"）
        /// </summary>
        [XmlElement("check_labels")]
        public string CheckLabels { get; set; }

        /// <summary>
        /// 用户发表内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 数据唯一标识，能够根据该值定位到该条数据
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 由内容安全服务分配的产品账号标识
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 发表时间，UNIX 时间戳(毫秒值)
        /// </summary>
        [XmlElement("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 业务请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
