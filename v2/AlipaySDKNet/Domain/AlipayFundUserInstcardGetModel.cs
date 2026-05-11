using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundUserInstcardGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundUserInstcardGetModel : AopObject
    {
        /// <summary>
        /// 根据实际业务，转账场景传以下8大场景其中之一： 佣金报酬，行政补贴，业务结算，二手回收，企业退款，现金营销，保险理赔，公益补助 根据实际业务，充值场景传以下4大场景其中之一： 销卡充值，企业充值，账户充值，营销充值
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户账户ID，如支付宝UID, 场景钱包ID,支付宝登录账号等
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 用户账户ID，如支付宝UID, 场景钱包ID,支付宝登录账号等
        /// </summary>
        [XmlElement("identity_open_id")]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 用户账户类型，如ALIPAY_USER_ID支付宝UID、SCENE_WALLET_ID 支付宝场景钱包、ALIPAY_LOGON_ID 支付宝登录ID
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 合作银行在支付宝侧的PID
        /// </summary>
        [XmlElement("inst_alipay_pid")]
        public string InstAlipayPid { get; set; }

        /// <summary>
        /// 当identityType=ALIPAY_LOGIN_ID时，name必选
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 支付宝open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码，固定值：BANK_TO_ALIPAY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
