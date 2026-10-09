using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationServiceTaskdetailQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationServiceTaskdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// response_data为JSON序列化字符串，结构如下： SUMMARY：data{amount:可用流量币，单位个,totalAmount:累计获得量，单位个,expAmount:即将过期量，单位个,totalExpiredAmount:已过期量，单位个,expiringAmount:临近过期量，单位个} EARN_TASK：data{activityType:活动类型,beginTime:开始时间,endTime:结束时间,status:任务状态,weeklyAmount:本周期可获得量,remainTradeCount:剩余交易笔数} EARN_DETAIL：data[{outBizNo:外部业务单号,sendTime:发放时间,amount:获得数量}],pageInfo{pageNum,pageSize,totalPages,totalRecords} LAUNCH_DETAIL：data[{launchChannel:投放渠道,deductTime:扣除时间,deductCoinAmount:扣除流量币数量}],pageInfo{pageNum,pageSize,totalPages,totalRecords} EFFECT_SUMMARY：data{launchAmount:投放总量,launchSuccessCnt:投放成功量,cliNum:点击用户数,tradeNum:成交交易数} RULE_STATUS：data{taskType:活动类型,shopList[{shopId:关联的闪购门店ID,shopName:门店名称}]} SHOP_EFFECT：data[{shopId:闪购门店ID,sendCnt:投放量,expCnt:曝光量,clkCnt:点击量,conversionRate:转化率,orderCnt:成交订单数}],pageInfo{pageNum,pageSize,totalPages,totalRecords}。
        /// </summary>
        [XmlElement("response_data")]
        public string ResponseData { get; set; }

        /// <summary>
        /// 服务code，如流量币服务ALIPAY_LLB
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
