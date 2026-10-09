using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandApprecommendAccountDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandApprecommendAccountDeleteModel : AopObject
    {
        /// <summary>
        /// 待解绑账号PID
        /// </summary>
        [XmlElement("acc_no")]
        public string AccNo { get; set; }

        /// <summary>
        /// 待解绑小程序的app_id
        /// </summary>
        [XmlElement("app_no")]
        public string AppNo { get; set; }
    }
}
