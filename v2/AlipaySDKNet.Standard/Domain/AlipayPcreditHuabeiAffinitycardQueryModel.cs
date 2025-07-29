using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAffinitycardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAffinitycardQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务场景，hellobike_hb_card-哈罗花呗联名卡
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
