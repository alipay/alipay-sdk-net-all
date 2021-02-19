using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessItem Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessItem : AopObject
    {
        /// <summary>
        /// 业务归属appid
        /// </summary>
        [XmlElement("business_appid")]
        public string BusinessAppid { get; set; }

        /// <summary>
        /// 业务收款pid，business_type为AGREEMENT_PAY时，此参数必传
        /// </summary>
        [XmlElement("business_payee_id")]
        public string BusinessPayeeId { get; set; }

        /// <summary>
        /// 业务归属pid
        /// </summary>
        [XmlElement("business_pid")]
        public string BusinessPid { get; set; }

        /// <summary>
        /// 业务类型ONLINE_PAY(在线缴费) 、AGREEMENT_PAY(无感停车)
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }
    }
}
