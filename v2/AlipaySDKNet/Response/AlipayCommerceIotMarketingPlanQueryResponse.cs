using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotMarketingPlanQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMarketingPlanQueryResponse : AopResponse
    {
        /// <summary>
        /// 设备bizTid
        /// </summary>
        [XmlArray("biz_ids")]
        [XmlArrayItem("string")]
        public List<string> BizIds { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 结束时间戳
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 上传图片的文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 修改时间时间戳
        /// </summary>
        [XmlElement("modify_time")]
        public long ModifyTime { get; set; }

        /// <summary>
        /// 投放计划Id
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
        /// 海报图片展位编码
        /// </summary>
        [XmlElement("space_code")]
        public string SpaceCode { get; set; }

        /// <summary>
        /// 开始时间戳
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// WAITTING_AUDIT(0, "待审核"),     AUDITING(1, "审核中"),     AUDIT_SUCCESS(2, "审核成功"),     AUDIT_FAIL(3, "审核失败"),     ONLINE(4, "已上线"),     OFFLINE(5, "已失效");
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
