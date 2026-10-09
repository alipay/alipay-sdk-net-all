using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCustomertagSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCustomertagSaveModel : AopObject
    {
        /// <summary>
        /// 业务场景码。由支付宝产品经理分配，相当于存储标签的使用凭证。
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 含义：支付宝会员的openId，是用户（userId）在应用（AppId）下的唯一用户标识（新接入的ISV必传open_id，不传user_id）。网关会将传入的open_id字段的值转换为user_id（2088格式），并放入与之映射的原user_id字段，并移除open_id参数，业务系统获取到的参数仅有user_id。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 标签名字
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签值，常见为T,F
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 支付宝会员uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
