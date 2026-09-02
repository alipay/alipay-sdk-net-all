using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinExpressverificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinExpressverificationQueryModel : AopObject
    {
        /// <summary>
        /// 星河侧快递订单号
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 外部快递订单号
        /// </summary>
        [XmlElement("out_express_no")]
        public string OutExpressNo { get; set; }
    }
}
