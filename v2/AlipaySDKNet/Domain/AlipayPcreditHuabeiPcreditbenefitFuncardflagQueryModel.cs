using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditbenefitFuncardflagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiPcreditbenefitFuncardflagQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 是否查询饿了么额度券信息，默认false
        /// </summary>
        [XmlElement("funk_edu_quan")]
        public bool FunkEduQuan { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 是否查询花呗签约，默认false
        /// </summary>
        [XmlElement("query_hb_sign_flag")]
        public bool QueryHbSignFlag { get; set; }

        /// <summary>
        /// 是否查询用户加密后的绑定手机号，默认false
        /// </summary>
        [XmlElement("query_mobile")]
        public bool QueryMobile { get; set; }

        /// <summary>
        /// 是否查询青春版状态，默认false
        /// </summary>
        [XmlElement("query_youth")]
        public bool QueryYouth { get; set; }
    }
}
