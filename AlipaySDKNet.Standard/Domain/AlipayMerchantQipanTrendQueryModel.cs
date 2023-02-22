using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanTrendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanTrendQueryModel : AopObject
    {
        /// <summary>
        /// 指标key，由棋盘注册，全局唯一，查询内容参考：<a href="https://opendocs.alipay.com/pre-open/04phhq#%E8%B6%8B%E5%8A%BF%E5%88%86%E6%9E%90%E4%B8%8D%E5%90%8Cindex_key%E6%9F%A5%E8%AF%A2" target="_blank">趋势分析不同index_key查询</a>
        /// </summary>
        [XmlElement("index_key")]
        public string IndexKey { get; set; }

        /// <summary>
        /// 趋势数据请求参数，如起止时间、关系类型、聚合维度等。
        /// </summary>
        [XmlElement("request_params")]
        public TrendQueryRequest RequestParams { get; set; }
    }
}
