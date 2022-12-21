using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserQuanyibaoOpenbenefitSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserQuanyibaoOpenbenefitSendModel : AopObject
    {
        /// <summary>
        /// 支付宝登录账号，支持邮箱和手机号格式，与alipay_user_id字段必须选填一个
        /// </summary>
        [XmlElement("alipay_login_id")]
        public string AlipayLoginId { get; set; }

        /// <summary>
        /// 支付宝的会员ID，与alipay_login_id字段必须选填一个
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 要发放的权益id，权益需联系权益宝业务方获取
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 权益发放扩展字段，用于权益发放动作的额外补充，如备注信息。由权益宝定义，使用时需提前和权益宝沟通是否满足需求
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("q_y_b_map_info")]
        public List<QYBMapInfo> ExtInfo { get; set; }

        /// <summary>
        /// 权益宝权益发放备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户app_id维度下的用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 权益发放第三方业务号，权益宝会使用该字段做幂等，请保证该值唯一
        /// </summary>
        [XmlElement("third_biz_no")]
        public string ThirdBizNo { get; set; }
    }
}
