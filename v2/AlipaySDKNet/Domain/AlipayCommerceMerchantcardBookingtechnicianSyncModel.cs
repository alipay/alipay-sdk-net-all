using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardBookingtechnicianSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardBookingtechnicianSyncModel : AopObject
    {
        /// <summary>
        /// 手艺人头像文件id 来源于alipay.open.file.upload支付宝文件上传接口
        /// </summary>
        [XmlElement("avatar_file_id")]
        public string AvatarFileId { get; set; }

        /// <summary>
        /// 手艺人从业开始月份 格式 yyyy-MM【首次同步手艺人信息时必填】
        /// </summary>
        [XmlElement("career_start_month")]
        public string CareerStartMonth { get; set; }

        /// <summary>
        /// 手艺人昵称【首次同步手艺人信息时必填】
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 外部手艺人id【可选，有就传】
        /// </summary>
        [XmlElement("out_technician_id")]
        public string OutTechnicianId { get; set; }

        /// <summary>
        /// 手艺人手机号【首次同步手艺人信息时必填】
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_ids")]
        [XmlArrayItem("string")]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// 门店id【必填】
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 手艺人状态（枚举）【首次同步手艺人信息时必填】 deleted      永久删除，后续不可恢复，不可再被查询到 active       可预约状态 inactive     不可预约，后续可恢复成active
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 手艺人id 为空表示新建/有值表示更新
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }

        /// <summary>
        /// 手艺人岗位头衔【首次同步手艺人信息时必填】
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("week_plans")]
        [XmlArrayItem("schedule_week_plan_info")]
        public List<ScheduleWeekPlanInfo> WeekPlans { get; set; }
    }
}
