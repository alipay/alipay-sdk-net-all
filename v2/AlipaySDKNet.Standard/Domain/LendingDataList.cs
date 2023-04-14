using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LendingDataList Data Structure.
    /// </summary>
    [Serializable]
    public class LendingDataList : AopObject
    {
        /// <summary>
        /// 最新 FBA 库存价值（基于上架货品价格） WFCF0000 WFCF0000=[0-10000），WFCF0001=[10000-20000），依次类推
        /// </summary>
        [XmlElement("curr_fba_inv_value")]
        public string CurrFbaInvValue { get; set; }

        /// <summary>
        /// 币种，The three-character ISO-4217 currency code
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 第 8月的回款 WFD8M0000
        /// </summary>
        [XmlElement("disbursements_eight_m")]
        public string DisbursementsEightM { get; set; }

        /// <summary>
        /// 第 8季度的回款 WFD8Q0000
        /// </summary>
        [XmlElement("disbursements_eight_q")]
        public string DisbursementsEightQ { get; set; }

        /// <summary>
        /// 第 11月的回款 WFD11M0000
        /// </summary>
        [XmlElement("disbursements_eleven_m")]
        public string DisbursementsElevenM { get; set; }

        /// <summary>
        /// 第 5月的回款 WFD5M0000
        /// </summary>
        [XmlElement("disbursements_five_m")]
        public string DisbursementsFiveM { get; set; }

        /// <summary>
        /// 第 5季度的回款 WFD5Q0000
        /// </summary>
        [XmlElement("disbursements_five_q")]
        public string DisbursementsFiveQ { get; set; }

        /// <summary>
        /// 第 5 周的回款 WFD5W0000
        /// </summary>
        [XmlElement("disbursements_five_w")]
        public string DisbursementsFiveW { get; set; }

        /// <summary>
        /// 第 4月的回款 WFD4M0000
        /// </summary>
        [XmlElement("disbursements_four_m")]
        public string DisbursementsFourM { get; set; }

        /// <summary>
        /// 第 4季度的回款 WFD4Q0000
        /// </summary>
        [XmlElement("disbursements_four_q")]
        public string DisbursementsFourQ { get; set; }

        /// <summary>
        /// 第 4 周的回款 WFD4W0000
        /// </summary>
        [XmlElement("disbursements_four_w")]
        public string DisbursementsFourW { get; set; }

        /// <summary>
        /// 第 9月的回款 WFD9M0000
        /// </summary>
        [XmlElement("disbursements_nine_m")]
        public string DisbursementsNineM { get; set; }

        /// <summary>
        /// 第 1月的回款 WFD1M0000 示例说明： WFD2M0000=[0-1000），WFD2M0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("disbursements_one_m")]
        public string DisbursementsOneM { get; set; }

        /// <summary>
        /// 第 1季度的回款 WFD1Q0000 WFD2Q0000=[0-1000），WFD2Q0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("disbursements_one_q")]
        public string DisbursementsOneQ { get; set; }

        /// <summary>
        /// 第 1 周的回款 WFD1W0000 示例说明： WFD1W0000=[0-1000），WFD1W0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("disbursements_one_w")]
        public string DisbursementsOneW { get; set; }

        /// <summary>
        /// 第 1年的回款 WFD1Y0000 WFD1Y0000=[0-10000），WFD1Y0001=[10000-20000），依次类推
        /// </summary>
        [XmlElement("disbursements_one_y")]
        public string DisbursementsOneY { get; set; }

        /// <summary>
        /// 第 7月的回款 WFD7M0000
        /// </summary>
        [XmlElement("disbursements_seven_m")]
        public string DisbursementsSevenM { get; set; }

        /// <summary>
        /// 第7季度的回款 WFD7Q0000
        /// </summary>
        [XmlElement("disbursements_seven_q")]
        public string DisbursementsSevenQ { get; set; }

        /// <summary>
        /// 第 6月的回款 WFD6M0000
        /// </summary>
        [XmlElement("disbursements_six_m")]
        public string DisbursementsSixM { get; set; }

        /// <summary>
        /// 第 6季度的回款 WFD6Q0000
        /// </summary>
        [XmlElement("disbursements_six_q")]
        public string DisbursementsSixQ { get; set; }

        /// <summary>
        /// String (32) 第 6周的回款 WFD6W0000
        /// </summary>
        [XmlElement("disbursements_six_w")]
        public string DisbursementsSixW { get; set; }

        /// <summary>
        /// 第 10月的回款 WFD10M0000
        /// </summary>
        [XmlElement("disbursements_ten_m")]
        public string DisbursementsTenM { get; set; }

        /// <summary>
        /// 第 3月的回款 WFD3M0000
        /// </summary>
        [XmlElement("disbursements_three_m")]
        public string DisbursementsThreeM { get; set; }

        /// <summary>
        /// 第 3季度的回款 WFD3Q0000
        /// </summary>
        [XmlElement("disbursements_three_q")]
        public string DisbursementsThreeQ { get; set; }

        /// <summary>
        /// 第 3 周的回款 WFD3W0000
        /// </summary>
        [XmlElement("disbursements_three_w")]
        public string DisbursementsThreeW { get; set; }

        /// <summary>
        /// 第 12月的回款 WFD12M0000
        /// </summary>
        [XmlElement("disbursements_twelve_m")]
        public string DisbursementsTwelveM { get; set; }

        /// <summary>
        /// 第 2月的回款 WFD2M0000
        /// </summary>
        [XmlElement("disbursements_two_m")]
        public string DisbursementsTwoM { get; set; }

        /// <summary>
        /// 第 2季度的回款 WFD2Q0000
        /// </summary>
        [XmlElement("disbursements_two_q")]
        public string DisbursementsTwoQ { get; set; }

        /// <summary>
        /// 第 2 周的回款 WFD2W0000 示例说明： WFD2W0000=[0-1000），WFD2W0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("disbursements_two_w")]
        public string DisbursementsTwoW { get; set; }

        /// <summary>
        /// 第 2年度的回款 WFD2Y0000
        /// </summary>
        [XmlElement("disbursements_two_y")]
        public string DisbursementsTwoY { get; set; }

        /// <summary>
        /// 店铺所在站点 = region
        /// </summary>
        [XmlElement("marketplace_country")]
        public string MarketplaceCountry { get; set; }

        /// <summary>
        /// AMZ offerid
        /// </summary>
        [XmlElement("offer_id")]
        public string OfferId { get; set; }

        /// <summary>
        /// 卖家主要销售产品销售额 WFPS3M0000 WFPS3M0000=[0-10000），WFPS3M0001=[10000-20000），依次类推
        /// </summary>
        [XmlElement("primary_category_last_three_month_sales_value")]
        public string PrimaryCategoryLastThreeMonthSalesValue { get; set; }

        /// <summary>
        /// 最近 3 个月销售额占比最高的货品
        /// </summary>
        [XmlElement("primary_product_category")]
        public string PrimaryProductCategory { get; set; }

        /// <summary>
        /// 数据生成日期
        /// </summary>
        [XmlElement("report_card_data_date")]
        public string ReportCardDataDate { get; set; }

        /// <summary>
        /// 第 8月的销售额 WFS8M0000
        /// </summary>
        [XmlElement("sales_eight_m")]
        public string SalesEightM { get; set; }

        /// <summary>
        /// 第 8季度的销售额 WFS8Q0000
        /// </summary>
        [XmlElement("sales_eight_q")]
        public string SalesEightQ { get; set; }

        /// <summary>
        /// 第 11月的销售额 WFS11M0000
        /// </summary>
        [XmlElement("sales_eleven_m")]
        public string SalesElevenM { get; set; }

        /// <summary>
        /// 第 5月的销售额 WFS5M0000
        /// </summary>
        [XmlElement("sales_five_m")]
        public string SalesFiveM { get; set; }

        /// <summary>
        /// 第 5季度的销售额 WFS5Q0000
        /// </summary>
        [XmlElement("sales_five_q")]
        public string SalesFiveQ { get; set; }

        /// <summary>
        /// 第 5 周的销售额 WFS5W0000
        /// </summary>
        [XmlElement("sales_five_w")]
        public string SalesFiveW { get; set; }

        /// <summary>
        /// 第 4月的销售额 WFS4M0000
        /// </summary>
        [XmlElement("sales_four_m")]
        public string SalesFourM { get; set; }

        /// <summary>
        /// 第 4季度的销售额 WFS4Q0000
        /// </summary>
        [XmlElement("sales_four_q")]
        public string SalesFourQ { get; set; }

        /// <summary>
        /// 第 4 周的销售额 WFS4W0000
        /// </summary>
        [XmlElement("sales_four_w")]
        public string SalesFourW { get; set; }

        /// <summary>
        /// 第 9月的销售额 WFS9M0000
        /// </summary>
        [XmlElement("sales_nine_m")]
        public string SalesNineM { get; set; }

        /// <summary>
        /// 第 1月的销售额 WFS1M0000 示例说明： WFS2M0000=[0-1000），WFS2M0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("sales_one_m")]
        public string SalesOneM { get; set; }

        /// <summary>
        /// 第 1季度的销售额 WFS1Q0000 WFS2Q0000=[0-1000），WFS2Q0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("sales_one_q")]
        public string SalesOneQ { get; set; }

        /// <summary>
        /// 第 1 周的销售额 WFS1W0000 示例说明： WFS1W0000=[0-1000），WFS1W0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("sales_one_w")]
        public string SalesOneW { get; set; }

        /// <summary>
        /// 第 1年的销售额 WFS1Y0000 WFS1Y0000=[0-10000），WFS1Y0001=[10000-20000），依次类推
        /// </summary>
        [XmlElement("sales_one_y")]
        public string SalesOneY { get; set; }

        /// <summary>
        /// 第 7月的销售额 WFS7M0000
        /// </summary>
        [XmlElement("sales_seven_m")]
        public string SalesSevenM { get; set; }

        /// <summary>
        /// 第7季度的销售额 WFS7Q0000
        /// </summary>
        [XmlElement("sales_seven_q")]
        public string SalesSevenQ { get; set; }

        /// <summary>
        /// 第 6月的销售额 WFS6M0000
        /// </summary>
        [XmlElement("sales_six_m")]
        public string SalesSixM { get; set; }

        /// <summary>
        /// 第 6季度的销售额 WFS6Q0000
        /// </summary>
        [XmlElement("sales_six_q")]
        public string SalesSixQ { get; set; }

        /// <summary>
        /// 第 6周的销售额 WFS6W0000
        /// </summary>
        [XmlElement("sales_six_w")]
        public string SalesSixW { get; set; }

        /// <summary>
        /// 卖方销售稳定得分
        /// </summary>
        [XmlElement("sales_stability_score")]
        public string SalesStabilityScore { get; set; }

        /// <summary>
        /// 第 10月的销售额 WFS10M0000
        /// </summary>
        [XmlElement("sales_ten_m")]
        public string SalesTenM { get; set; }

        /// <summary>
        /// 第 3月的销售额 WFS3M0000
        /// </summary>
        [XmlElement("sales_three_m")]
        public string SalesThreeM { get; set; }

        /// <summary>
        /// 第 3季度的销售额 WFS3Q0000
        /// </summary>
        [XmlElement("sales_three_q")]
        public string SalesThreeQ { get; set; }

        /// <summary>
        /// 第 3 周的销售额 WFS3W0000
        /// </summary>
        [XmlElement("sales_three_w")]
        public string SalesThreeW { get; set; }

        /// <summary>
        /// 第 12月的销售额 WFS12M0000
        /// </summary>
        [XmlElement("sales_twelve_m")]
        public string SalesTwelveM { get; set; }

        /// <summary>
        /// 第 2月的销售额 WFS2M0000
        /// </summary>
        [XmlElement("sales_two_m")]
        public string SalesTwoM { get; set; }

        /// <summary>
        /// 第 2季度的销售额 WFS2Q0000
        /// </summary>
        [XmlElement("sales_two_q")]
        public string SalesTwoQ { get; set; }

        /// <summary>
        /// 第 2 周的销售额 WFS2W0000 示例说明： WFS2W0000=[0-1000），WFS2W0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("sales_two_w")]
        public string SalesTwoW { get; set; }

        /// <summary>
        /// 第 2年度的销售额 WFS2Y0000
        /// </summary>
        [XmlElement("sales_two_y")]
        public string SalesTwoY { get; set; }

        /// <summary>
        /// 店铺状态 枚举：Normal/Abnormal
        /// </summary>
        [XmlElement("seller_status")]
        public string SellerStatus { get; set; }

        /// <summary>
        /// 过去13个周FBA发货比例 WFFBA00 示例说明： WFFBA01=[0-10%），WFFBA02=[10%-20%），依次类推
        /// </summary>
        [XmlElement("t_thirteen_wk_fba")]
        public string TThirteenWkFba { get; set; }

        /// <summary>
        /// 过去3个月平均库存价值 （基于上架价格） WFFBA3M0000 WFFBA3M0000=[0-10000），WFFBA3M0001=[10000-20000），依次类推
        /// </summary>
        [XmlElement("t_three_m_fba_inv_value")]
        public string TThreeMFbaInvValue { get; set; }

        /// <summary>
        /// 期限，卖家经营时长 天数/365, 四舍五入取1位小数
        /// </summary>
        [XmlElement("tenure")]
        public string Tenure { get; set; }

        /// <summary>
        /// 过去12个月的取消总订单数 WFC1Y0000 WFC1Y0000=[0-500），WFC1Y0001=[500-1000），依次类推
        /// </summary>
        [XmlElement("ttm_cancellations")]
        public string TtmCancellations { get; set; }

        /// <summary>
        /// 过去 12 个月卖家警告总次数 WFE1Y0000 WFE1Y0000=[0-5），WFE1Y0001=[5-10），依次类推
        /// </summary>
        [XmlElement("ttm_enforcements")]
        public string TtmEnforcements { get; set; }

        /// <summary>
        /// 过去12个月客户总反馈数 WFFD1Y0000 WFFD1Y0000=[0-100），WFFD1Y0001=[100-200），依次类推
        /// </summary>
        [XmlElement("ttm_feedback")]
        public string TtmFeedback { get; set; }

        /// <summary>
        /// 过去12个月的延迟配送总订单数 WFLS1Y0000 WFLS1Y0000=[0-100），WFLS1Y0001=[100-200），依次类推
        /// </summary>
        [XmlElement("ttm_late_shipments")]
        public string TtmLateShipments { get; set; }

        /// <summary>
        /// 过去 3 个月低于 3星的评价数 WFNFD1Y0000 WFNFD1Y0000=[0-100），WFNFD1Y0001=[100-200），依次类推
        /// </summary>
        [XmlElement("ttm_neg_feedback")]
        public string TtmNegFeedback { get; set; }

        /// <summary>
        /// 过去12个月的瑕疵品总订单数 WFDO1Y0000 WFDO1Y0000=[0-100），WFDO1Y0001=[100-200），依次类推
        /// </summary>
        [XmlElement("ttm_order_defects")]
        public string TtmOrderDefects { get; set; }

        /// <summary>
        /// 过去12个月的总订单数 WFO1Y0000 WFO1Y0000=[0-1000），WFO1Y0001=[1000-2000），依次类推
        /// </summary>
        [XmlElement("ttm_orders")]
        public string TtmOrders { get; set; }

        /// <summary>
        /// 过去12个月的退款总订单数 WFR1Y0000 WFR1Y0000=[0-500），WFR1Y0001=[500-1000），依次类推
        /// </summary>
        [XmlElement("ttm_returns")]
        public string TtmReturns { get; set; }
    }
}
