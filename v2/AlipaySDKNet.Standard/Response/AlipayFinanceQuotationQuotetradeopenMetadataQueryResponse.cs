using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenMetadataQueryResponse.
    /// </summary>
    public class AlipayFinanceQuotationQuotetradeopenMetadataQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回结果（JSON格式），biz_type为STOCK_SYMBOL_BATCH时，biz_content为证券信息列表。返回信息字段名及含义如下： symbol：股票唯一代码，symbol=code.market 。例600519.SH； code：产品code。例：600519； name：名称。例：贵州茅台； market：产品交易所。例：SH-上交所，SZ-深交所； type：产品类型。例：ES-股票，EU-基金； subType：产品子类型。例：ASH-主板A股，ETF-ETF产品； listType：上市状态。例：ListType_D-正常交易，ListType_W-未上市，ListType_E-退市； chineseName：中文名。例：贵州茅台。
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
