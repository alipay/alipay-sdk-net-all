using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiSceneprodBenefitSendModel : AopObject
    {
        /// <summary>
        /// 权益渠道，用于控制投放场景 帮还会场入会 member_huabei 店铺页面入会 member_tmall 帮还会场直播 live_huabei
        /// </summary>
        [XmlElement("benefit_channel")]
        public string BenefitChannel { get; set; }

        /// <summary>
        /// 权益ID，创建成功后返回
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 标识权益类型，花呗金：HB_POINT_BENEFIT
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 业务传递时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务场景，后续更多新增请联系相关同学，入淘：HB_POINT_TAOBAO
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 活动实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 发放描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 创建权益的支付宝商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 安全所需参数，如IP，UMID等
        /// </summary>
        [XmlElement("security_content")]
        public string SecurityContent { get; set; }

        /// <summary>
        /// 支付宝的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
