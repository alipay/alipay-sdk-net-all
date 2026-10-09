using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantJobInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantJobInfo : AopObject
    {
        /// <summary>
        /// 活跃商家标签【是/否】
        /// </summary>
        [XmlElement("active_tag")]
        public bool ActiveTag { get; set; }

        /// <summary>
        /// 作业服务商名称
        /// </summary>
        [XmlElement("job_group_name")]
        public string JobGroupName { get; set; }

        /// <summary>
        /// 作业商家门店名称
        /// </summary>
        [XmlElement("leads_name")]
        public string LeadsName { get; set; }

        /// <summary>
        /// 商户openId
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 作业小二姓名
        /// </summary>
        [XmlElement("woker_name")]
        public string WokerName { get; set; }
    }
}
