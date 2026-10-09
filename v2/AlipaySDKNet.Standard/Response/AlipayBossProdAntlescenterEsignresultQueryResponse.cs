using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlescenterEsignresultQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlescenterEsignresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 系统来源名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 业务唯一流水id
        /// </summary>
        [XmlElement("business_unique_id")]
        public string BusinessUniqueId { get; set; }

        /// <summary>
        /// 用印数字加签完成文件的下载地址
        /// </summary>
        [XmlElement("oss_file_addr")]
        public string OssFileAddr { get; set; }

        /// <summary>
        /// 发起电子签署成功返回的流水id
        /// </summary>
        [XmlElement("seal_request_id")]
        public string SealRequestId { get; set; }

        /// <summary>
        /// 业务用印处理状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
