using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseReliableauthSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEnterpriseReliableauthSyncModel : AopObject
    {
        /// <summary>
        /// 企业注册来源渠道<br/> 调用方根据实际来源传入对应值 
        /// </summary>
        [XmlElement("access_channel")]
        public string AccessChannel { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("enterprise_code")]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业id<br/> 可信渠道通过创建企业接口后，获得的企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }
    }
}
