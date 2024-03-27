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
        /// 根据ad_level不同会透出汇总数据的plan_id/group_id/creative_id/order_id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

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
        /// 投放产品名称
        /// </summary>
        [XmlElement("scene_name")]
        public string SceneName { get; set; }
    }
}
