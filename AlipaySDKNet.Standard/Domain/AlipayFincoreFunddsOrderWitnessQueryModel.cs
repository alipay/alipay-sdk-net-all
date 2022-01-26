using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreFunddsOrderWitnessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreFunddsOrderWitnessQueryModel : AopObject
    {
        /// <summary>
        /// 20211118000000000000000027001023
        /// </summary>
        [XmlElement("fds_no")]
        public string FdsNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
