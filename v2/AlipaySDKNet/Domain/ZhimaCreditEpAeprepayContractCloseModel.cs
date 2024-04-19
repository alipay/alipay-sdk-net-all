using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpAeprepayContractCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpAeprepayContractCloseModel : AopObject
    {
        /// <summary>
        /// AE卖家ID
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }
    }
}
