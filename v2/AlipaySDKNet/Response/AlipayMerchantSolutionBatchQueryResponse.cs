using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantSolutionBatchQueryResponse.
    /// </summary>
    public class AlipayMerchantSolutionBatchQueryResponse : AopResponse
    {
        /// <summary>
        /// 提报成功后，支付宝侧生成的提报批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 标识当前该批次的处理状态
        /// </summary>
        [XmlElement("batch_status_code")]
        public string BatchStatusCode { get; set; }

        /// <summary>
        /// 当前批次处理状态的中文描述
        /// </summary>
        [XmlElement("batch_status_desc")]
        public string BatchStatusDesc { get; set; }

        /// <summary>
        /// 使用文件下载链接下载文件时，需要在header中带上返回的token，设置为x-mass-token:${token}。为保证数据安全，不要对外泄露该字段。
        /// </summary>
        [XmlElement("file_token")]
        public string FileToken { get; set; }

        /// <summary>
        /// 批次提报结果文件的下载链接，需结合file_token字段一起使用。链接有效时间默认1小时，超时需重新获取。
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 外部批次号，在外部系统中唯一标识一个提报批次
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }
    }
}
