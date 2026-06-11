using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitFuncardbenefitSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitFuncardbenefitSendModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 直发花呗金场景：发放的花呗金数量，花呗金单位 个，1个花呗金等价于1分，飞猪场景可以传飞猪履约金额用于发奖定价
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 外部业务单据id
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务场景，飞猪可以填入履约场景，枚举可以飞猪给出后续进行扩展
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
