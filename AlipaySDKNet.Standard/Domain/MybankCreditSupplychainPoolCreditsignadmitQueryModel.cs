using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainPoolCreditsignadmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainPoolCreditsignadmitQueryModel : AopObject
    {
        /// <summary>
        /// 客户支付宝登录号，在饿了么发薪贷场景是外包服务供应商的支付宝登录号
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 渠道标签，固定值，待网商分配
        /// </summary>
        [XmlElement("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// 合作机构ipRoleId，比如饿了么ipRoleId
        /// </summary>
        [XmlElement("data_org_ip_role_id")]
        public string DataOrgIpRoleId { get; set; }
    }
}
