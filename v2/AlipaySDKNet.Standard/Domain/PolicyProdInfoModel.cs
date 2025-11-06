using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PolicyProdInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyProdInfoModel : AopObject
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }
    }
}
