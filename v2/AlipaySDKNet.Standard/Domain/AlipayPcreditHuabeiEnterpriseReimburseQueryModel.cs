using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiEnterpriseReimburseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiEnterpriseReimburseQueryModel : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 获取数据的code，在消息发送时会带出
        /// </summary>
        [XmlElement("record_code")]
        public string RecordCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
