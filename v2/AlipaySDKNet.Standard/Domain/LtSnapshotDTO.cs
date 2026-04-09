using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LtSnapshotDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LtSnapshotDTO : AopObject
    {
        /// <summary>
        /// 盘后竞价成交额
        /// </summary>
        [XmlElement("after_market_amount")]
        public string AfterMarketAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("after_market_buy_orders")]
        [XmlArrayItem("lt_order_d_t_o")]
        public List<LtOrderDTO> AfterMarketBuyOrders { get; set; }

        /// <summary>
        /// 盘后竞价买入申报数量,当前未成交的买入申报总股数
        /// </summary>
        [XmlElement("after_market_buy_volume")]
        public string AfterMarketBuyVolume { get; set; }

        /// <summary>
        /// 盘后竞价价格
        /// </summary>
        [XmlElement("after_market_price")]
        public string AfterMarketPrice { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("after_market_sell_orders")]
        [XmlArrayItem("lt_order_d_t_o")]
        public List<LtOrderDTO> AfterMarketSellOrders { get; set; }

        /// <summary>
        /// 盘后竞价卖出申报数量
        /// </summary>
        [XmlElement("after_market_sell_volume")]
        public string AfterMarketSellVolume { get; set; }

        /// <summary>
        /// 盘后竞价最后交易时间
        /// </summary>
        [XmlElement("after_market_trade_time")]
        public string AfterMarketTradeTime { get; set; }

        /// <summary>
        /// 盘后竞价交易状态说明, 参考枚举 AfterMarketTradingPhase
        /// </summary>
        [XmlElement("after_market_trading_phase")]
        public string AfterMarketTradingPhase { get; set; }

        /// <summary>
        /// 盘后固定价格交易成交笔数
        /// </summary>
        [XmlElement("after_market_transactions")]
        public string AfterMarketTransactions { get; set; }

        /// <summary>
        /// 盘后竞价成交量
        /// </summary>
        [XmlElement("after_market_volume")]
        public string AfterMarketVolume { get; set; }

        /// <summary>
        /// 成交额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("asks")]
        [XmlArrayItem("lt_bid_ask_level_d_t_o")]
        public List<LtBidAskLevelDTO> Asks { get; set; }

        /// <summary>
        /// 市场状态归属日期
        /// </summary>
        [XmlElement("belong_day")]
        public string BelongDay { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("bids")]
        [XmlArrayItem("lt_bid_ask_level_d_t_o")]
        public List<LtBidAskLevelDTO> Bids { get; set; }

        /// <summary>
        /// 大单参数,超过多少单算作大单
        /// </summary>
        [XmlElement("big_order_volume")]
        public string BigOrderVolume { get; set; }

        /// <summary>
        /// 涨跌幅
        /// </summary>
        [XmlElement("change_percent")]
        public string ChangePercent { get; set; }

        /// <summary>
        /// 涨跌额
        /// </summary>
        [XmlElement("change_price")]
        public string ChangePrice { get; set; }

        /// <summary>
        /// 价格涨跌状态
        /// </summary>
        [XmlElement("change_price_status")]
        public string ChangePriceStatus { get; set; }

        /// <summary>
        /// 渠道来源交易所 eg. SH
        /// </summary>
        [XmlElement("channel_exchange")]
        public string ChannelExchange { get; set; }

        /// <summary>
        /// 渠道来源数据质量 eg. L1
        /// </summary>
        [XmlElement("channel_level")]
        public string ChannelLevel { get; set; }

        /// <summary>
        /// 收盘价
        /// </summary>
        [XmlElement("close_price")]
        public string ClosePrice { get; set; }

        /// <summary>
        /// 时间, 最后交易的时间
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 跌停价
        /// </summary>
        [XmlElement("down_price")]
        public string DownPrice { get; set; }

        /// <summary>
        /// 最高价
        /// </summary>
        [XmlElement("high_price")]
        public string HighPrice { get; set; }

        /// <summary>
        /// 基金IOPV
        /// </summary>
        [XmlElement("iopv")]
        public string Iopv { get; set; }

        /// <summary>
        /// 基金IOPV iopvTm1
        /// </summary>
        [XmlElement("iopv_tm_1")]
        public string IopvTm1 { get; set; }

        /// <summary>
        /// 涨/跌停状态
        /// </summary>
        [XmlElement("limit_state")]
        public string LimitState { get; set; }

        /// <summary>
        /// 最低价
        /// </summary>
        [XmlElement("low_price")]
        public string LowPrice { get; set; }

        /// <summary>
        /// 市场状态
        /// </summary>
        [XmlElement("market_state")]
        public string MarketState { get; set; }

        /// <summary>
        /// 市场状态描述
        /// </summary>
        [XmlElement("market_state_desc")]
        public string MarketStateDesc { get; set; }

        /// <summary>
        /// 买盘限价上限(港股通)
        /// </summary>
        [XmlElement("max_buy_limit_price")]
        public string MaxBuyLimitPrice { get; set; }

        /// <summary>
        /// 卖盘限价上限(港股通)
        /// </summary>
        [XmlElement("max_sell_limit_price")]
        public string MaxSellLimitPrice { get; set; }

        /// <summary>
        /// 买盘限价下限(港股通)
        /// </summary>
        [XmlElement("min_buy_limit_price")]
        public string MinBuyLimitPrice { get; set; }

        /// <summary>
        /// 卖盘限价下限(港股通)
        /// </summary>
        [XmlElement("min_sell_limit_price")]
        public string MinSellLimitPrice { get; set; }

        /// <summary>
        /// 中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 开盘价
        /// </summary>
        [XmlElement("open_price")]
        public string OpenPrice { get; set; }

        /// <summary>
        /// 溢价率（基金）
        /// </summary>
        [XmlElement("premium_rate")]
        public string PremiumRate { get; set; }

        /// <summary>
        /// 昨收价
        /// </summary>
        [XmlElement("previous_close")]
        public string PreviousClose { get; set; }

        /// <summary>
        /// 当前价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 振幅
        /// </summary>
        [XmlElement("range_percent")]
        public string RangePercent { get; set; }

        /// <summary>
        /// 数据状况 1,NORMAL 正常，2,ABNORMAL 不正常  参考枚举 level2.proto SituationType,沪深 L2 专用
        /// </summary>
        [XmlElement("situation")]
        public string Situation { get; set; }

        /// <summary>
        /// 快照生成时间(前置机), 递增时间戳
        /// </summary>
        [XmlElement("snapshot_date")]
        public string SnapshotDate { get; set; }

        /// <summary>
        /// 停牌, 长期停牌, 临时停牌等
        /// </summary>
        [XmlElement("suspension_state")]
        public string SuspensionState { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// 最小价差(港股通)
        /// </summary>
        [XmlElement("tick_size")]
        public string TickSize { get; set; }

        /// <summary>
        /// 市场所属时区
        /// </summary>
        [XmlElement("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 委卖总量 对应L1 totalSellVolume
        /// </summary>
        [XmlElement("total_ask_volume")]
        public string TotalAskVolume { get; set; }

        /// <summary>
        /// 委买总量 对应L1 totalBuyVolume
        /// </summary>
        [XmlElement("total_bid_volume")]
        public string TotalBidVolume { get; set; }

        /// <summary>
        /// 集合竞价, 交易中, 休市, 收盘集合竞价, 熔断等
        /// </summary>
        [XmlElement("trade_state")]
        public string TradeState { get; set; }

        /// <summary>
        /// 涨停价
        /// </summary>
        [XmlElement("up_price")]
        public string UpPrice { get; set; }

        /// <summary>
        /// 成交量
        /// </summary>
        [XmlElement("volume")]
        public string Volume { get; set; }

        /// <summary>
        /// 加权委托卖出均价 对应L1 averageSellPrice
        /// </summary>
        [XmlElement("weighted_ask_price")]
        public string WeightedAskPrice { get; set; }

        /// <summary>
        /// // 加权委托买入价 对应L1 averageBuyPrice
        /// </summary>
        [XmlElement("weighted_bid_price")]
        public string WeightedBidPrice { get; set; }
    }
}
