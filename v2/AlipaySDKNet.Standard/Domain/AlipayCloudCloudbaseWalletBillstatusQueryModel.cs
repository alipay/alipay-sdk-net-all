using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletBillstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseWalletBillstatusQueryModel : AopObject
    {
        /// <summary>
        /// 出账日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }
    }
}
