using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommercePeriodcardIndirectconfigCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommercePeriodcardIndirectconfigCreateModel : AopObject
    {
        /// <summary>
        /// 群组code，注意有售卖订单后不能修改该字段
        /// </summary>
        [XmlElement("group_code")]
        public string GroupCode { get; set; }

        /// <summary>
        /// 群组信用服务id，注意有售卖订单后不能修改该字段
        /// </summary>
        [XmlElement("group_zm_service_id")]
        public string GroupZmServiceId { get; set; }

        /// <summary>
        /// 接口消息通知appid，只用于alipay.commerce.merchantcard.deduct.notify接口
        /// </summary>
        [XmlElement("notify_app_id")]
        public string NotifyAppId { get; set; }

        /// <summary>
        /// 机构pid，注意有售卖订单后不能修改该字段
        /// </summary>
        [XmlElement("org_pid")]
        public string OrgPid { get; set; }

        /// <summary>
        /// 扣款场景码，注意有售卖订单后不能修改该字段
        /// </summary>
        [XmlElement("sign_scene")]
        public string SignScene { get; set; }
    }
}
