using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiSceneprodBenefitCreateModel : AopObject
    {
        /// <summary>
        /// 权益渠道，用于控制投放场景 帮还会场入会 member_huabei 店铺页面入会 member_tmall 帮还会场直播 live_huabei
        /// </summary>
        [XmlElement("benefit_channel")]
        public string BenefitChannel { get; set; }

        /// <summary>
        /// 权益名称，有商户创建
        /// </summary>
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 标识权益类型，花呗金：HB_POINT
        /// </summary>
        [XmlElement("benefit_type")]
        public string BenefitType { get; set; }

        /// <summary>
        /// 业务场景，后续更多新增请联系相关同学，入淘：HB_POINT_TAOBAO
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 花呗金发放预算
        /// </summary>
        [XmlElement("budget")]
        public long Budget { get; set; }

        /// <summary>
        /// 权益结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部业务号，上游唯一单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 创建权益的支付宝商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 淘宝商家sellerId
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 面值，单次发放数量
        /// </summary>
        [XmlElement("send_count")]
        public long SendCount { get; set; }

        /// <summary>
        /// 权益开始时间，如不传递则创建时生效
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
