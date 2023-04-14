using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 小程序appid，支持带跳转链接
        /// </summary>
        [XmlElement("applet_id")]
        public string AppletId { get; set; }

        /// <summary>
        /// 创建业务幂等号
        /// </summary>
        [XmlElement("create_biz_no")]
        public string CreateBizNo { get; set; }

        /// <summary>
        /// 出资方id
        /// </summary>
        [XmlElement("funder_id")]
        public string FunderId { get; set; }

        /// <summary>
        /// 出资方类型：品牌BRAND，零售商RETAILER，平台PLATFORM
        /// </summary>
        [XmlElement("funder_type")]
        public string FunderType { get; set; }

        /// <summary>
        /// 激励对象： SHOP 门店 MERCHANT 商户 HUNTER 导购员
        /// </summary>
        [XmlElement("incentive")]
        public string Incentive { get; set; }

        /// <summary>
        /// 激励方式： PRESTROKE 逐笔 FIXEDLADDER 固定阶梯 ALGOLADDER 算法阶梯
        /// </summary>
        [XmlElement("incentive_mode")]
        public string IncentiveMode { get; set; }

        /// <summary>
        /// 激励规则, json字符
        /// </summary>
        [XmlElement("incentive_rule")]
        public string IncentiveRule { get; set; }

        /// <summary>
        /// 商户pid， 代运营模式需要
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作者uid
        /// </summary>
        [XmlElement("operate_open_id")]
        public string OperateOpenId { get; set; }

        /// <summary>
        /// 操作者uid
        /// </summary>
        [XmlElement("operate_user_id")]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 活动方id
        /// </summary>
        [XmlElement("organizer_id")]
        public string OrganizerId { get; set; }

        /// <summary>
        /// 活动方名称
        /// </summary>
        [XmlElement("organizer_name")]
        public string OrganizerName { get; set; }

        /// <summary>
        /// 活动方类型：零售商RETAILER
        /// </summary>
        [XmlElement("organizer_type")]
        public string OrganizerType { get; set; }

        /// <summary>
        /// 招商信息，task_type=VOUCHER 必填
        /// </summary>
        [XmlElement("plan_info")]
        public PlanInfo PlanInfo { get; set; }

        /// <summary>
        /// 支持统一物料码激励到店长, 默认false
        /// </summary>
        [XmlElement("support_unified_material_code")]
        public bool SupportUnifiedMaterialCode { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [XmlElement("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [XmlElement("task_end_time")]
        public string TaskEndTime { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [XmlElement("task_start_time")]
        public string TaskStartTime { get; set; }

        /// <summary>
        /// 任务模版id，有值则编辑覆盖
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }

        /// <summary>
        /// 任务类型： VOUCHER 优惠券核销 IOT lot核销
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }
    }
}
