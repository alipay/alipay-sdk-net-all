using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ISPTaskInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ISPTaskInfo : AopObject
    {
        /// <summary>
        /// 投放设备bizTid列表
        /// </summary>
        [XmlArray("biz_ids")]
        [XmlArrayItem("string")]
        public List<string> BizIds { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 投放计划结束时间戳
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 图片文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public long ModifyTime { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 海报图片展位编码 电子海报:NORMAL_DISPLAY 支付结果页:PAY_SUCCESS_RESULT 商户信息海报:MERCHANT_INFO_POSTER
        /// </summary>
        [XmlElement("space_code")]
        public string SpaceCode { get; set; }

        /// <summary>
        /// 投放计划开始时间戳
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 4---已上线 5---已失效 6---上线失败
        /// </summary>
        [XmlElement("status_code")]
        public long StatusCode { get; set; }
    }
}
