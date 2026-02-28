using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HKStockConnSymbolDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HKStockConnSymbolDTO : AopObject
    {
        /// <summary>
        /// 股票代码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 市场类型, 如深港通 SZ 或沪港通 SH
        /// </summary>
        [XmlElement("conn_type")]
        public string ConnType { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 数据时间
        /// </summary>
        [XmlElement("date")]
        public long Date { get; set; }

        /// <summary>
        /// 港股通调入时间
        /// </summary>
        [XmlElement("listed_join_date")]
        public long ListedJoinDate { get; set; }

        /// <summary>
        /// 港股通调出时间
        /// </summary>
        [XmlElement("listed_leave_date")]
        public long ListedLeaveDate { get; set; }

        /// <summary>
        /// 是否支持港股通
        /// </summary>
        [XmlElement("listed_status")]
        public bool ListedStatus { get; set; }

        /// <summary>
        /// 最小购买股数
        /// </summary>
        [XmlElement("lot_size")]
        public long LotSize { get; set; }

        /// <summary>
        /// 表示标的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 业务子类型
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 股票标的, 如股票代码 00700.HK
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
