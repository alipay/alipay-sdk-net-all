using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceBusinessReportQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceBusinessReportQueryResponse : AopResponse
    {
        /// <summary>
        /// 商圈内品牌排行结果
        /// </summary>
        [XmlElement("brand_rank_dto")]
        public BrandRankDTO BrandRankDto { get; set; }

        /// <summary>
        /// 商圈范围居住人口数量
        /// </summary>
        [XmlElement("live_user_cnt_in_range_code")]
        public long LiveUserCntInRangeCode { get; set; }

        /// <summary>
        /// 商圈内用户画像结果
        /// </summary>
        [XmlElement("portrait_in_mall_dto")]
        public PortraitInMallResDTO PortraitInMallDto { get; set; }

        /// <summary>
        /// 商圈范围常驻人口数量
        /// </summary>
        [XmlElement("settled_user_cnt_in_range_code")]
        public long SettledUserCntInRangeCode { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 商圈范围工作人口数量
        /// </summary>
        [XmlElement("work_user_cnt_in_range_code")]
        public long WorkUserCntInRangeCode { get; set; }
    }
}
