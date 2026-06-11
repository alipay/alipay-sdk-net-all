using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinOrgexpressCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinOrgexpressCancelModel : AopObject
    {
        /// <summary>
        /// 星河快递单号
        /// </summary>
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 抵押单号
        /// </summary>
        [XmlElement("mortgage_no")]
        public string MortgageNo { get; set; }
    }
}
