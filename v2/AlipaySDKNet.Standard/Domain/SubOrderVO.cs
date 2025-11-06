using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubOrderVO Data Structure.
    /// </summary>
    [Serializable]
    public class SubOrderVO : AopObject
    {
        /// <summary>
        /// 应付保费，单位为分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 若请求没有该入参，则通过格式为：被保人姓名|证件类型|证件号码
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }

        /// <summary>
        /// 总保费，单位为分
        /// </summary>
        [XmlElement("total_premium")]
        public long TotalPremium { get; set; }
    }
}
