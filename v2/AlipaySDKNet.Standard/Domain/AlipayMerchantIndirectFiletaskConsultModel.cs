using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectFiletaskConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectFiletaskConsultModel : AopObject
    {
        /// <summary>
        /// 业务参数，必须遵循业务定义
        /// </summary>
        [XmlElement("biz_params")]
        public string BizParams { get; set; }

        /// <summary>
        /// 业务场景，根据具体接入的业务确定，由平台分配而来。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务类型，属于业务场景下的子业务分类，接入具体业务时由平台业务定义。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 通过alipay.open.file.upload接口上传文件后得到的文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 服务商在支付宝的PID
        /// </summary>
        [XmlElement("source_pid")]
        public string SourcePid { get; set; }
    }
}
