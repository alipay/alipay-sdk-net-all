using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentKolDailyReportVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentKolDailyReportVO : AopObject
    {
        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 入驻达人昵称
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 推广口令词
        /// </summary>
        [XmlElement("search_word")]
        public string SearchWord { get; set; }

        /// <summary>
        /// 可结算订单数量
        /// </summary>
        [XmlElement("settled_cnt")]
        public long SettledCnt { get; set; }

        /// <summary>
        /// 15到30元可结算订单数量
        /// </summary>
        [XmlElement("settled_cnt_15_to_30")]
        public long SettledCnt15To30 { get; set; }

        /// <summary>
        /// 30元以上可结算订单数量
        /// </summary>
        [XmlElement("settled_cnt_over_30")]
        public long SettledCntOver30 { get; set; }

        /// <summary>
        /// 用来标识推广分享的方式，口令词渠道归属于任务分享。
        /// </summary>
        [XmlElement("share_type")]
        public string ShareType { get; set; }

        /// <summary>
        /// 拟结算订单数量
        /// </summary>
        [XmlElement("to_be_settle_cnt")]
        public long ToBeSettleCnt { get; set; }

        /// <summary>
        /// 15到30元拟结算订单数量
        /// </summary>
        [XmlElement("to_be_settle_cnt_15_to_30")]
        public long ToBeSettleCnt15To30 { get; set; }

        /// <summary>
        /// 30元以上拟结算订单数量
        /// </summary>
        [XmlElement("to_be_settle_cnt_over_30")]
        public long ToBeSettleCntOver30 { get; set; }

        /// <summary>
        /// 有效访问数量
        /// </summary>
        [XmlElement("uv_cnt")]
        public long UvCnt { get; set; }
    }
}
