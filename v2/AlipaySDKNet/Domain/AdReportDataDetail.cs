using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdReportDataDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AdReportDataDetail : AopObject
    {
        /// <summary>
        /// 查询素材数据，ALL层级透出
        /// </summary>
        [XmlElement("action_point")]
        public string ActionPoint { get; set; }

        /// <summary>
        /// 查询素材数据，ALL层级透出
        /// </summary>
        [XmlElement("action_point_id")]
        public string ActionPointId { get; set; }

        /// <summary>
        /// 代理商账号(只在代理商接口返回)
        /// </summary>
        [XmlElement("agent_alipay_account")]
        public string AgentAlipayAccount { get; set; }

        /// <summary>
        /// 代理商名称(只在代理商接口返回)
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 广告主为每个转化所付出的平均成本(单位:元)，计算方式：总消耗/转化量
        /// </summary>
        [XmlElement("avg_conv_cost")]
        public string AvgConvCost { get; set; }

        /// <summary>
        /// 当query_type为DETAIL时数据汇总时间格式yyyyMMdd；当按ALL_SUM时该出参非必填
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 点击量，当无投放未产生点击数据时，查询数据为空
        /// </summary>
        [XmlElement("click")]
        public long Click { get; set; }

        /// <summary>
        /// 广告被点击的次数占展示次数的百分比。计算方法：点击数/展示量*100
        /// </summary>
        [XmlElement("click_rate")]
        public string ClickRate { get; set; }

        /// <summary>
        /// 按转化事件发生时间统计的转化数
        /// </summary>
        [XmlElement("conv_result")]
        public string ConvResult { get; set; }

        /// <summary>
        /// 投放转化数据，当无投放未产生转化数据或未绑定转化事件时，查询数据为空
        /// </summary>
        [XmlArray("conversion_data_list")]
        [XmlArrayItem("ad_report_conversion_data_detail")]
        public List<AdReportConversionDataDetail> ConversionDataList { get; set; }

        /// <summary>
        /// 消费金额，单位:分。当无投放未产生消费数据时，查询数据为空
        /// </summary>
        [XmlElement("cost")]
        public long Cost { get; set; }

        /// <summary>
        /// 消费金额(单位:元)
        /// </summary>
        [XmlElement("cost_format")]
        public string CostFormat { get; set; }

        /// <summary>
        /// 广告主为每次点击付出的费用成本(单位:元)，计算公式是：总消耗/点击量
        /// </summary>
        [XmlElement("cpc")]
        public string Cpc { get; set; }

        /// <summary>
        /// 广告平均每一千次展现所付出的费用(单位:元)，计算公式是：总消耗/展示量*1000
        /// </summary>
        [XmlElement("cpm")]
        public string Cpm { get; set; }

        /// <summary>
        /// 创意id
        /// </summary>
        [XmlElement("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 创意名称
        /// </summary>
        [XmlElement("creative_name")]
        public string CreativeName { get; set; }

        /// <summary>
        /// 广告被用户转化的次数占点击次数的百分比。计算方式：转化量/点击量*100
        /// </summary>
        [XmlElement("cvr")]
        public string Cvr { get; set; }

        /// <summary>
        /// 根据ad_level不同会透出汇总数据的plan_id/group_id/creative_id/order_id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 单元ID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 展现量，当无投放未产生展现数据时，查询数据为空
        /// </summary>
        [XmlElement("impression")]
        public long Impression { get; set; }

        /// <summary>
        /// 查询素材数据，非VIDEO层级透出
        /// </summary>
        [XmlElement("main_picture_height")]
        public string MainPictureHeight { get; set; }

        /// <summary>
        /// 查询素材数据时，非VIDEO层级时透出
        /// </summary>
        [XmlElement("main_picture_id")]
        public string MainPictureId { get; set; }

        /// <summary>
        /// 查询素材数据，非VIDEO层级透出
        /// </summary>
        [XmlElement("main_picture_name")]
        public string MainPictureName { get; set; }

        /// <summary>
        /// 查询素材数据，非VIDEO层级透出
        /// </summary>
        [XmlElement("main_picture_url")]
        public string MainPictureUrl { get; set; }

        /// <summary>
        /// 查询素材数据，非VIDEO层级透出
        /// </summary>
        [XmlElement("main_picture_width")]
        public string MainPictureWidth { get; set; }

        /// <summary>
        /// 查询素材数据，ALL层级透出
        /// </summary>
        [XmlElement("main_title")]
        public string MainTitle { get; set; }

        /// <summary>
        /// 查询素材数据，ALL层级透出
        /// </summary>
        [XmlElement("main_title_id")]
        public string MainTitleId { get; set; }

        /// <summary>
        /// 查询素材数据，非PHOTO层级透出
        /// </summary>
        [XmlElement("main_video_height")]
        public long MainVideoHeight { get; set; }

        /// <summary>
        /// 查询素材数据，非PHOTO层级透出
        /// </summary>
        [XmlElement("main_video_id")]
        public string MainVideoId { get; set; }

        /// <summary>
        /// 查询素材数据，非PHOTO层级透出
        /// </summary>
        [XmlElement("main_video_name")]
        public string MainVideoName { get; set; }

        /// <summary>
        /// 查询素材数据，非PHOTO层级透出
        /// </summary>
        [XmlElement("main_video_url")]
        public string MainVideoUrl { get; set; }

        /// <summary>
        /// 查询素材数据，非PHOTO层级透出
        /// </summary>
        [XmlElement("main_video_width")]
        public long MainVideoWidth { get; set; }

        /// <summary>
        /// 营销目标名称
        /// </summary>
        [XmlElement("market_target_name")]
        public string MarketTargetName { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单名称
        /// </summary>
        [XmlElement("order_name")]
        public string OrderName { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 商家账户
        /// </summary>
        [XmlElement("principal_alipay_account")]
        public string PrincipalAlipayAccount { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }

        /// <summary>
        /// 商家PID
        /// </summary>
        [XmlElement("principal_pid")]
        public string PrincipalPid { get; set; }

        /// <summary>
        /// 投放产品名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }

        /// <summary>
        /// 查询素材数据，ALL层级透出
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 查询素材数据，ALL层级透出
        /// </summary>
        [XmlElement("sub_title_id")]
        public string SubTitleId { get; set; }
    }
}
