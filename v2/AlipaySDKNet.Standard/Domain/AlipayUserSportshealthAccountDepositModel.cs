using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSportshealthAccountDepositModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportshealthAccountDepositModel : AopObject
    {
        /// <summary>
        /// 设备反查标识，风控需要
        /// </summary>
        [XmlElement("apdid_token")]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 发放运动币数量
        /// </summary>
        [XmlElement("award_amount")]
        public long AwardAmount { get; set; }

        /// <summary>
        /// 客户端IP，风控需要
        /// </summary>
        [XmlElement("client_ip")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 是否直发，默认为false，如果为true的话，发放后直接自动领取
        /// </summary>
        [XmlElement("is_award_directly")]
        public bool IsAwardDirectly { get; set; }

        /// <summary>
        /// 支付宝用户开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部渠道
        /// </summary>
        [XmlElement("out_biz_channel")]
        public string OutBizChannel { get; set; }

        /// <summary>
        /// 外部业务号,用于幂等使用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发币子场景
        /// </summary>
        [XmlElement("sub_scene")]
        public string SubScene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
