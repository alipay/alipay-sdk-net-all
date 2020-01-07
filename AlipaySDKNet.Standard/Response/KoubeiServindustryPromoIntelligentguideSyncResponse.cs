using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideSyncResponse.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideSyncResponse : AopResponse
    {
        /// <summary>
        /// 单次上传交易数据失败条数数量
        /// </summary>
        [XmlElement("failure_count")]
        public long FailureCount { get; set; }

        /// <summary>
        /// 非法交易列表，上传数据如果校验不通过，则放入该列表中返回给isv。如果全部通过，则该列表为空
        /// </summary>
        [XmlArray("invalid_trade_details")]
        [XmlArrayItem("invalid_trade_detail")]
        public List<InvalidTradeDetail> InvalidTradeDetails { get; set; }

        /// <summary>
        /// 单次上传交易数据校验成功的数量
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
