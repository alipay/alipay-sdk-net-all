using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCheckconfigCheckconfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCheckconfigCheckconfigModifyModel : AopObject
    {
        /// <summary>
        /// 活动编码
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 活动规则按钮名称
        /// </summary>
        [XmlElement("activity_rule_button_name")]
        public string ActivityRuleButtonName { get; set; }

        /// <summary>
        /// 跳转类型：link(链接)、img(图片)
        /// </summary>
        [XmlElement("activity_rule_jump_type")]
        public string ActivityRuleJumpType { get; set; }

        /// <summary>
        /// 打卡模式：NORMAL(通用模式)、AOI_plugin(AOI打卡模式)
        /// </summary>
        [XmlElement("check_activity_delivery_channel")]
        public string CheckActivityDeliveryChannel { get; set; }

        /// <summary>
        /// 打卡模板类型
        /// </summary>
        [XmlElement("check_template_type")]
        public string CheckTemplateType { get; set; }

        /// <summary>
        /// 收集品名称
        /// </summary>
        [XmlElement("collection_name")]
        public string CollectionName { get; set; }

        /// <summary>
        /// 打卡类型
        /// </summary>
        [XmlElement("collection_type")]
        public string CollectionType { get; set; }

        /// <summary>
        /// 每日活动更新
        /// </summary>
        [XmlElement("day_update_activity")]
        public string DayUpdateActivity { get; set; }

        /// <summary>
        /// 活动规则配置（图片URL）
        /// </summary>
        [XmlElement("guide_image")]
        public string GuideImage { get; set; }

        /// <summary>
        /// mall_id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 强制展示（1次）
        /// </summary>
        [XmlElement("must_to_descrition")]
        public string MustToDescrition { get; set; }

        /// <summary>
        /// 支付结果页插件投放
        /// </summary>
        [XmlElement("open_pay_result_page")]
        public string OpenPayResultPage { get; set; }

        /// <summary>
        /// 是否开启分享
        /// </summary>
        [XmlElement("open_share")]
        public string OpenShare { get; set; }

        /// <summary>
        /// 场馆展示
        /// </summary>
        [XmlElement("open_venue_exhibifion")]
        public string OpenVenueExhibifion { get; set; }

        /// <summary>
        /// 支付结果页跳转链接
        /// </summary>
        [XmlElement("pay_result_page_action_url")]
        public string PayResultPageActionUrl { get; set; }

        /// <summary>
        /// 随机收集
        /// </summary>
        [XmlElement("random_check_place")]
        public string RandomCheckPlace { get; set; }

        /// <summary>
        /// 关联地图
        /// </summary>
        [XmlElement("rel_map")]
        public string RelMap { get; set; }

        /// <summary>
        /// 关联展商页
        /// </summary>
        [XmlElement("rel_merchant_page")]
        public string RelMerchantPage { get; set; }

        /// <summary>
        /// 服务商AppId
        /// </summary>
        [XmlElement("service_provider_pid")]
        public string ServiceProviderPid { get; set; }

        /// <summary>
        /// 订阅打卡进度
        /// </summary>
        [XmlElement("sync_service_provider")]
        public string SyncServiceProvider { get; set; }

        /// <summary>
        /// 活动logo
        /// </summary>
        [XmlElement("title_image")]
        public string TitleImage { get; set; }
    }
}
