using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConfigInfo : AopObject
    {
        /// <summary>
        /// 附件信息（collect_attachement值为true时必填）
        /// </summary>
        [XmlElement("attachment_explain")]
        public AttachmentExplain AttachmentExplain { get; set; }

        /// <summary>
        /// 是否收集附件
        /// </summary>
        [XmlElement("collect_attachement")]
        public bool CollectAttachement { get; set; }

        /// <summary>
        /// 收集证件类型列表
        /// </summary>
        [XmlArray("collect_cert_types")]
        [XmlArrayItem("string")]
        public List<string> CollectCertTypes { get; set; }

        /// <summary>
        /// 公司编号-SF
        /// </summary>
        [XmlElement("company_no")]
        public string CompanyNo { get; set; }

        /// <summary>
        /// 文档过期时间
        /// </summary>
        [XmlElement("contract_validity")]
        public long ContractValidity { get; set; }

        /// <summary>
        /// 支付宝小程序跳转
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 回调地址，签署的过程和签署完成都会回调。
        /// </summary>
        [XmlElement("notice_developer_url")]
        public string NoticeDeveloperUrl { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("platform_order_no")]
        public string PlatformOrderNo { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
