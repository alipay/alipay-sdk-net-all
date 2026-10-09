using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasDigitalcredentialInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasDigitalcredentialInitializeModel : AopObject
    {
        /// <summary>
        /// 客户生成的业务唯一标识，用于查询用户完成数字凭证授权后生成的凭证单据。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }
    }
}
