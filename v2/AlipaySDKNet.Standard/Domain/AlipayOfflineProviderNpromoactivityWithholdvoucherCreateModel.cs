using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderNpromoactivityWithholdvoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderNpromoactivityWithholdvoucherCreateModel : AopObject
    {
        /// <summary>
        /// 创建代扣单业务时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 用户单期子活动的id
        /// </summary>
        [XmlElement("sub_activity_id")]
        public string SubActivityId { get; set; }
    }
}
