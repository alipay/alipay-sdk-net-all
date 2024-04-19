using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletBalanceGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseWalletBalanceGetModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }
    }
}
