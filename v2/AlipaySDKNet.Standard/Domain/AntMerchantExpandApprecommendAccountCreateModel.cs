using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandApprecommendAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandApprecommendAccountCreateModel : AopObject
    {
        /// <summary>
        /// 待绑定账号PID
        /// </summary>
        [XmlElement("acc_no")]
        public string AccNo { get; set; }

        /// <summary>
        /// 待绑定小程序的app_id
        /// </summary>
        [XmlElement("app_no")]
        public string AppNo { get; set; }
    }
}
