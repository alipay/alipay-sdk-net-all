using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRetailPromoactivitySaveResponse.
    /// </summary>
    public class AlipayCommerceRetailPromoactivitySaveResponse : AopResponse
    {
        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 返参列表
        /// </summary>
        [XmlElement("response_list")]
        public string ResponseList { get; set; }
    }
}
