using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardTransferCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardTransferCreateModel : AopObject
    {
        /// <summary>
        /// 需要修改的最新卡信息
        /// </summary>
        [XmlElement("card_info")]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 业务发生时间，时间格式为"yyyy-MM-dd HH:mm:ss"。
        /// </summary>
        [XmlElement("occur_time")]
        public string OccurTime { get; set; }

        /// <summary>
        /// 外部流水号，标识一次跨主体迁移，全局唯一。
        /// </summary>
        [XmlElement("out_serial_no")]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 必须为已经审核通过放行的原卡实例创建pid
        /// </summary>
        [XmlElement("source_pid")]
        public string SourcePid { get; set; }

        /// <summary>
        /// 必须为已经审核通过放行的原卡实例对应的卡模板id
        /// </summary>
        [XmlElement("source_template_id")]
        public string SourceTemplateId { get; set; }

        /// <summary>
        /// 支付宝业务卡号：1、3.0（历史版本）版本来源于alipay.marketing.card.open(会员卡开卡)接口开卡后获取的 card_info.biz_card_no 值；2、极速版来源于spi.alipay.user.opencard.get(会员卡开通，获取会员卡信息)请求参数中的biz_card_no值。
        /// </summary>
        [XmlElement("target_card_no")]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型
        /// </summary>
        [XmlElement("target_card_no_type")]
        public string TargetCardNoType { get; set; }
    }
}
