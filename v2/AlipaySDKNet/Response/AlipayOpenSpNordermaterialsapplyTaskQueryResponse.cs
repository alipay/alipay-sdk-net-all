using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyTaskQueryResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 近30天内有交易情况，有为TRUE，无为FALSE，无数据、未知为UNKNOWN
        /// </summary>
        [XmlElement("has_monthly_trade")]
        public string HasMonthlyTrade { get; set; }

        /// <summary>
        /// 近7天内有交易情况，有为TRUE，无为FALSE，无数据、未知为UNKNOWN
        /// </summary>
        [XmlElement("has_weekly_trade")]
        public string HasWeeklyTrade { get; set; }

        /// <summary>
        /// 近30天内交易笔数，可空
        /// </summary>
        [XmlElement("monthly_trade_cnt")]
        public long MonthlyTradeCnt { get; set; }

        /// <summary>
        /// 小二当前作业的门店，所在位置唯一标识
        /// </summary>
        [XmlElement("poi_mid")]
        public string PoiMid { get; set; }

        /// <summary>
        /// 门店物流信息状态，有多个快递单号时，数组中会有多个元素
        /// </summary>
        [XmlArray("shop_task_delivery_info_list")]
        [XmlArrayItem("shop_task_delivery_info")]
        public List<ShopTaskDeliveryInfo> ShopTaskDeliveryInfoList { get; set; }

        /// <summary>
        /// 门店作业单据标识唯一标识，一个作业单据只需要支付一次保证金
        /// </summary>
        [XmlElement("shop_task_id")]
        public string ShopTaskId { get; set; }

        /// <summary>
        /// ● INFO_COLLECTION：信息收集；选择完作业模式后，默认该状态 ● MATETIAL_PRODUCTION：线圈生产，确认完成信息收集后进入该状态 ● ACCEPTANCE：作业验收，确认收货后进入该状态 ● FINISHED：作业完成，作业验收通过后进入该状态 ● DEPRECATED：废弃，未创建作业单导致门店被释放、作废时，进入该状态
        /// </summary>
        [XmlElement("shop_task_status")]
        public string ShopTaskStatus { get; set; }

        /// <summary>
        /// 近7天内交易笔数，可空
        /// </summary>
        [XmlElement("weekly_trade_cnt")]
        public long WeeklyTradeCnt { get; set; }
    }
}
