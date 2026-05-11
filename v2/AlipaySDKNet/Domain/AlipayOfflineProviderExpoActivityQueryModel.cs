using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoActivityQueryModel : AopObject
    {
        /// <summary>
        /// 活动唯一编码，精确查询
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 活动状态（参考创建接口状态定义）： EFFECTIVE - 执行中 EXPIRED - 已执行完成
        /// </summary>
        [XmlElement("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 页码，从1开始。默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数，最大50。默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
