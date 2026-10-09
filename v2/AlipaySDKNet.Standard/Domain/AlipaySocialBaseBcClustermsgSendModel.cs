using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseBcClustermsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseBcClustermsgSendModel : AopObject
    {
        /// <summary>
        /// 是否at所有人
        /// </summary>
        [XmlElement("at_all")]
        public bool AtAll { get; set; }

        /// <summary>
        /// 业务方id，消息发送时可传入，消息列表返回
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 客户群分组id，此id唯一，分组下会管理一系列的客户群
        /// </summary>
        [XmlArray("cluster_ids")]
        [XmlArrayItem("string")]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// template_code= IMAGE是的消息数据结构体
        /// </summary>
        [XmlElement("image_template_data")]
        public ImageTemplateData ImageTemplateData { get; set; }

        /// <summary>
        /// template_code= LINKS时的消息数据结构体
        /// </summary>
        [XmlElement("links_template_data")]
        public LinksTemplateData LinksTemplateData { get; set; }

        /// <summary>
        /// template_code= MINIAPP时的消息结构体
        /// </summary>
        [XmlElement("miniapp_template_data")]
        public MiniAppTemplateData MiniappTemplateData { get; set; }

        /// <summary>
        /// 分组发消息名称
        /// </summary>
        [XmlElement("msg_name")]
        public string MsgName { get; set; }

        /// <summary>
        /// 操作的商家标识id，可选，默认是应用app下的pid；如果填写第三方商家标识id，需要保证app下的pid是该商家的管理员
        /// </summary>
        [XmlElement("operate_business_id")]
        public string OperateBusinessId { get; set; }

        /// <summary>
        /// 发送模板code，可选以下值 TEXT,IMAGE,LINKS,MINIAPP
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 客户群业务租户id，比如生态商家此id为7，b站开通商户为18
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 模板code=TEXT的消息结构体
        /// </summary>
        [XmlElement("text_template_data")]
        public TextTemplateData TextTemplateData { get; set; }
    }
}
