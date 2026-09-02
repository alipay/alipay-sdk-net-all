using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsVoicePlansnfailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsVoicePlansnfailQueryModel : AopObject
    {
        /// <summary>
        /// 毫秒时间戳
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 语音计划ID
        /// </summary>
        [XmlElement("logistics_voice_plan_id")]
        public string LogisticsVoicePlanId { get; set; }

        /// <summary>
        /// 默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 上一页最大数据ID，用于翻页
        /// </summary>
        [XmlElement("pre_page_max_data_id")]
        public string PrePageMaxDataId { get; set; }
    }
}
