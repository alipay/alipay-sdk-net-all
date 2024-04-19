using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContributeDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContributeDetailInfo : AopObject
    {
        /// <summary>
        /// 其它出资方金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("contribute_amount")]
        public string ContributeAmount { get; set; }

        /// <summary>
        /// 出资方类型，如品牌商出资、支付宝平台出资...
        /// </summary>
        [XmlElement("contribute_type")]
        public string ContributeType { get; set; }
    }
}
