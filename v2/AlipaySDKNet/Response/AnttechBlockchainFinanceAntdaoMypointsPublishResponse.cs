using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceAntdaoMypointsPublishResponse.
    /// </summary>
    public class AnttechBlockchainFinanceAntdaoMypointsPublishResponse : AopResponse
    {
        /// <summary>
        /// 集分宝卡密短链
        /// </summary>
        [XmlElement("card_url")]
        public string CardUrl { get; set; }

        /// <summary>
        /// 额外备注信息，非json形式
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 总费用
        /// </summary>
        [XmlElement("total_ccost")]
        public long TotalCcost { get; set; }
    }
}
