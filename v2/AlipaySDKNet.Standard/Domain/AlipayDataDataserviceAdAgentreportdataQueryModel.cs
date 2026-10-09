using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdAgentreportdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdAgentreportdataQueryModel : AopObject
    {
        /// <summary>
        /// 登录用户支付宝统一ID,2088开头字符串,代理商自身PID。
        /// </summary>
        [XmlElement("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 权限token,唯一值,在广告投放平台代理商详情获取。 <a href="https://opendocs.alipay.com/xlight/0eu31u?pathHash=79e13a13">获取文档</a>
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 转化指标code数组
        /// </summary>
        [XmlArray("conv_code_list")]
        [XmlArrayItem("string")]
        public List<string> ConvCodeList { get; set; }

        /// <summary>
        /// 转化时间归因：将广告带来的转化数据统计到广告转化发生（或广告转化回传）时间； 计费时间归因：将广告带来的转化数据统计到广告计费对应的事件（点击或曝光）发生时间; 【默认转化时间归因】
        /// </summary>
        [XmlElement("conv_time_join_rule")]
        public string ConvTimeJoinRule { get; set; }

        /// <summary>
        /// 分页查询的页码从1开始
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 投放模式
        /// </summary>
        [XmlElement("delivery_mode")]
        public string DeliveryMode { get; set; }

        /// <summary>
        /// 数据查询结束时间；汇总和分天查询时间范围不能大于7天，分时查询为1天；时间格式：yyyyMMdd【最大时间-最小时间<=7时间左闭右闭】
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 分页查询时每页返回条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 代理商商家标识,在广告投放平台代理商详情获取。<a href="https://opendocs.alipay.com/xlight/0eucvz?pathHash=dc01fadb">获取文档</a>
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 若未输入返回所有商家数据； 若输入了返回对应商家数据，要筛选查询的商家的标识，在广告投放平台商家详情获取。
        /// </summary>
        [XmlArray("principal_tag_list")]
        [XmlArrayItem("string")]
        public List<string> PrincipalTagList { get; set; }

        /// <summary>
        /// 数据汇总方式：汇总/明细分天/明细分小时。
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 接口出参是否透出转化指标数据，默认true；
        /// </summary>
        [XmlElement("show_conv_data")]
        public bool ShowConvData { get; set; }

        /// <summary>
        /// 数据查询开始时间；汇总和分天查询时间范围不能大于7天,分时为1天；时间格式：yyyyMMdd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
