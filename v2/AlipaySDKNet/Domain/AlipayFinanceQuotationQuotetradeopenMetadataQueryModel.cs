using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationQuotetradeopenMetadataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationQuotetradeopenMetadataQueryModel : AopObject
    {
        /// <summary>
        /// 业务查询条件（JSON格式），与业务类型对应。当biz_type为STOCK_SYMBOL_BATCH时，入参为symbol（格式code.market）列表，如 {"symbols":"600519.SH,002001.SZ"}。 当为STOCK_SYMBOL_COND时，入参为条件列表，如沪深股票{"market":"SH,SZ","type":"ES"}。 市场类型取值参考：https://yuque.antfin-inc.com/finquot/wvtttz/ta6dpn
        /// </summary>
        [XmlElement("biz_query")]
        public string BizQuery { get; set; }

        /// <summary>
        /// 业务查询类型，STOCK_SYMBOL_BATCH：证券码表批查；STOCK_SYMBOL_COND：证券码表条件查询
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }
    }
}
