using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceMindvTroublefreeruleConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvTroublefreeruleConsultModel : AopObject
    {
        /// <summary>
        /// 问卷ID值，调研平台获取
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 产品ID值，调研平台进行查询
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
