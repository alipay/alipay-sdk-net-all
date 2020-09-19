using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceOrderCreateModel : AopObject
    {
        /// <summary>
        /// 手机号,户号，卡号等
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 权益，活动，会员
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// json标准格式
        /// </summary>
        [XmlElement("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 流水创建时间
        /// </summary>
        [XmlElement("flow_time")]
        public string FlowTime { get; set; }

        /// <summary>
        /// 机构
        /// </summary>
        [XmlElement("inst")]
        public string Inst { get; set; }

        /// <summary>
        /// 操作动作
        /// </summary>
        [XmlElement("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 合作方子业务
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
