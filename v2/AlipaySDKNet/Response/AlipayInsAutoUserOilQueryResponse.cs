using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsAutoUserOilQueryResponse.
    /// </summary>
    public class AlipayInsAutoUserOilQueryResponse : AopResponse
    {
        /// <summary>
        /// 累计攒油量（不包含未收取油量）
        /// </summary>
        [XmlElement("accum_oil")]
        public long AccumOil { get; set; }

        /// <summary>
        /// 当前可兑换油量
        /// </summary>
        [XmlElement("current_oil")]
        public long CurrentOil { get; set; }

        /// <summary>
        /// 当前总油量（包含当前可兑换油量及未收取的油量 currentOil + unpickOil）
        /// </summary>
        [XmlElement("total_oil")]
        public long TotalOil { get; set; }

        /// <summary>
        /// 未收取油滴
        /// </summary>
        [XmlElement("unpick_oil")]
        public long UnpickOil { get; set; }

        /// <summary>
        /// 当前已使用油量
        /// </summary>
        [XmlElement("use_oil")]
        public long UseOil { get; set; }
    }
}
