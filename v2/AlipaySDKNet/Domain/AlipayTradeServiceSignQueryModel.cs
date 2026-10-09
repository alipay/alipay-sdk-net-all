using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeServiceSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeServiceSignQueryModel : AopObject
    {
        /// <summary>
        /// 用户蚂蚁统一会员id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 用户支付宝UID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 服务对应的业务场景，由支付宝分配，详见:https://yuque.antfin-inc.com/docs/share/cc027290-8a2c-4469-b4b9-602bffd0e0e6?#
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 服务类型，描述用户签约的某一类服务，目前仅支持无限付产品，固定值：LARGE_INFINITE
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
