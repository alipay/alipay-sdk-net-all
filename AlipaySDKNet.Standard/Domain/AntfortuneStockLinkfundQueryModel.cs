using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockLinkfundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockLinkfundQueryModel : AopObject
    {
        /// <summary>
        /// 返回限制数，默认为1
        /// </summary>
        [XmlElement("ret_limit")]
        public long RetLimit { get; set; }

        /// <summary>
        /// 股票代码+市场
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }
    }
}
