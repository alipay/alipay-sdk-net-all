using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalOperationDeliverQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalOperationDeliverQueryModel : AopObject
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 用户类型:0/1:支付宝/好大夫
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 参数信息
        /// </summary>
        [XmlElement("parameter_info")]
        public string ParameterInfo { get; set; }

        /// <summary>
        /// 用户输入的搜索词内容
        /// </summary>
        [XmlElement("query_str")]
        public string QueryStr { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 模版编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
